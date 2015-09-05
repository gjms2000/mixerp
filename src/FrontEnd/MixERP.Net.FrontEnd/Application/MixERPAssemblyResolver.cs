using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace MixERP.Net.FrontEnd.Application
{
    public class MixERPAssemblyResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);

            Type type = typeof(ApiController);

            IEnumerable<Assembly> items = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.IsSubclassOf(type)).Select(t => t.Assembly);

            foreach (var item in items)
            {
                baseAssemblies.Add(item);
            }

            return assemblies;
        }
    }
}