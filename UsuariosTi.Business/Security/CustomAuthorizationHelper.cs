using Microsoft.AspNetCore.Http;
using UsuariosTi.Business.ViewModels;
using System;
using System.Linq;
using System.Security.Claims;

namespace UsuariosTi.Business.Security
{
    public static class CustomAuthorizationHelper
    {
        public static bool ValidarClaimsUsuario(HttpContext context, Claim claim)
        {
            return context.User.Identity.IsAuthenticated &&
                   context.User.Claims.Any(c => c.Type == claim.Type && c.Value.Contains(claim.Value));
        }

        public static bool ValidarClaimsUsuario(HttpContext context, EPerfil[] perfisNecessarios)
        {
            if (!context.User.Identity.IsAuthenticated)
                return false;

            bool containsPerfil = false;

            var perfisClam = context.User.Claims.FirstOrDefault(x => x.Type == "Perfis");
            if (perfisClam != null)
            {
                string[] perfis = perfisClam.Value.Split(';');
                var perfisEnum = perfis?.Select(x => (EPerfil)Convert.ToInt32(x)).ToList();
                foreach (var p in perfisNecessarios)
                {
                    if (perfisEnum != null && perfisEnum.Contains(p))
                    {
                        containsPerfil = true;
                        break;
                    }
                }
            }
            return containsPerfil;
        }
    }
}
