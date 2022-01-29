using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Corretora.Business.Security;
using Corretora.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Corretora.App.Security
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly Claim _claim;
        private readonly EPerfil[] _perfisNecessarios;
        private readonly bool _isClaim;

        public CustomAuthorizeAttribute(string claimName, string claimValue)
        {
            _claim = new Claim(claimName, claimValue);
            _isClaim = true;
        }

        public CustomAuthorizeAttribute(EPerfil[] perfisNecessarios)
        {
            _perfisNecessarios = perfisNecessarios;
            _isClaim = false;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            if (_isClaim && !CustomAuthorizationHelper.ValidarClaimsUsuario(context.HttpContext, _claim))
            {
                context.Result = new ForbidResult();
                return;
            }

            if (!CustomAuthorizationHelper.ValidarClaimsUsuario(context.HttpContext, _perfisNecessarios))
            {
                context.Result = new ForbidResult();
            }
        }
    }
}