using Microsoft.AspNetCore.Http;
using UsuariosTi.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq.Expressions;
using System.Reflection;

namespace UsuariosTi.Business.Extensions
{
    public class AspNetUser : IUser
    {
        private readonly IHttpContextAccessor _accessor;

        public AspNetUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Nome => IsAuthenticated() ? _accessor.HttpContext.User.FindByType("Nome") : "";

        public string Matricula => IsAuthenticated() ? _accessor.HttpContext.User.FindByType("Matricula") : "";

        public string UnidadeNome => IsAuthenticated() ? _accessor.HttpContext.User.FindByType("UnidadeNome") : "";

        public string UnidadeCodigo => IsAuthenticated() ? _accessor.HttpContext.User.FindByType("UnidadeCodigo") : "";

        //public bool IsFuncionarioCaixa => IsAuthenticated() ? Matricula.StartsWith("C") : false;

        //public bool IsFuncionarioCaixa
        //{
        //    get
        //    {
        //        if (IsAuthenticated())
        //        {
        //           return Matricula.StartsWith("C");
        //        }
        //        return false;
        //    }
        //}

        public bool IsAuthenticated()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public ClaimsPrincipal GetClaimsPrincipal()
        {
            return _accessor.HttpContext.User;
        }

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            return _accessor.HttpContext.User.Claims;
        }

        public bool IsInRole(string role)
        {
            return _accessor.HttpContext.User.IsInRole(role);
        }
    }

    public static class ClaimsPrincipalExtensions
    {
        public static string FindByType(this ClaimsPrincipal principal, string type)
        {
            if (principal == null)
                throw new ArgumentException(nameof(principal));

            var claim = principal.FindFirst(type);
            return claim?.Value;
        }
    }

}