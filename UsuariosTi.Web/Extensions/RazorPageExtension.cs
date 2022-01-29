using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Corretora.Business.Extensions;
using Corretora.Business.Interfaces;
using Corretora.Business.Security;
using Corretora.Business.ViewModels;
using System.Security.Claims;

namespace Corretora.App.Extensions
{
    public static class RazorPageExtension
    {
        public static IUser GetUserCustom(this RazorPageBase razorPageBase)
        {
            var serviceProvider = razorPageBase.ViewContext.HttpContext.RequestServices;

            var user = serviceProvider.GetService<IUser>();

            return user;
        }

        public static bool CustomAuthorize(this RazorPageBase razorPage, EPerfil[] perfisNecessarios)
        {
            return CustomAuthorizationHelper.ValidarClaimsUsuario(razorPage.ViewContext.HttpContext, perfisNecessarios);
        }
    }
}
