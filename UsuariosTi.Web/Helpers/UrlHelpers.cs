using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using UsuariosTi.Web.Helpers;

namespace UsuariosTi.App.Helpers
{
    public static class UrlHelpers
    {

        public static bool BuscarNavegador()
        {
            var services = new ServiceCollection();
            services.AddScoped<NavegadorDados>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            var serviceProvider = services.BuildServiceProvider();
             return serviceProvider.GetService<NavegadorDados>().ValidarNavegadorFirefox();
        }
        public static string IsActionActive(this HtmlHelper html, string action, string control, bool controlOnly = false)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // both must match
            var returnActive = control.ToLower() == routeControl.ToLower() && action.ToLower() == routeAction.ToLower();

            if (controlOnly)
            {
                returnActive = control.ToLower() == routeControl.ToLower();
            }

            return returnActive ? "active" : "";
        }

        public static string IsActionActiveTreeview(this HtmlHelper html, string control)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // both must match
            var returnActive = control.ToLower() == routeControl.ToLower();

            return returnActive ? "active" : "";
        }
    }
}