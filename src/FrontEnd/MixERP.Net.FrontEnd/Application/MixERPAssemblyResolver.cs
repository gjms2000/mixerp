using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Serilog;

namespace MixERP.Net.FrontEnd.Application
{
    public class MixERPAssemblyResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);

            try
            {
                Type type = typeof (ApiController);

                IEnumerable<Assembly> items = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => p.IsSubclassOf(type)).Select(t => t.Assembly);

                foreach (Assembly item in items)
                {
                    baseAssemblies.Add(item);
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                foreach (Exception exception in ex.LoaderExceptions)
                {
                    Log.Error("Could not load assemblies containing MixERP Web API. Exception: {Exception}", exception);
                }
            }

            return assemblies;
        }
    }
}