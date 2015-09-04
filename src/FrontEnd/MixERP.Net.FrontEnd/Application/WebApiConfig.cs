using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace MixERP.Net.FrontEnd.Application
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{action}/{id}", new { id = RouteParameter.Optional });
            config.Services.Replace(typeof(IAssembliesResolver), new MixERPAssemblyResolver());

            config.EnsureInitialized();
        }
    }
}