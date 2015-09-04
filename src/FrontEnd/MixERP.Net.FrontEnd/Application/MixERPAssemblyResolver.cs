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
            Type type = typeof (ApiController);

            IEnumerable<Assembly> items = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.IsSubclassOf(type)).Select(t => t.Assembly);

            return items.ToList();
        }
    }
}