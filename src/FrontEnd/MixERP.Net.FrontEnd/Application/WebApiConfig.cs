using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace MixERP.Net.FrontEnd.Application
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("VersionedApi", "api/v1.5/{schema}/{controller}/{action}/{id}", new { id = RouteParameter.Optional });
            config.Routes.MapHttpRoute("DefaultApi", "api/{schema}/{controller}/{action}/{id}", new { id = RouteParameter.Optional });

            if (HttpRuntime.IISVersion.Major == 8 && HttpRuntime.IISVersion.Minor == 5)
            {
                config.Services.Replace(typeof (IAssembliesResolver), new MixERPAssemblyResolver());
            }
            else
            {
                config.Services.Replace(typeof(IAssembliesResolver), new ClassicAssemblyResolver());
            }

            config.EnsureInitialized();
        }
    }
}