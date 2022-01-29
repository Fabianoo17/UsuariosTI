using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Security;
using UsuariosTi.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosTi.App.Controllers
{
    public abstract class MainController : Controller
    {
        protected IUser UserCustom { get; private set; }

        protected MainController(IUser user)
        {
            UserCustom = user;
        }

        protected bool CustomAuthorize(EPerfil[] perfisNecessarios)
        {
            return CustomAuthorizationHelper.ValidarClaimsUsuario(HttpContext, perfisNecessarios);
        }
    }
}