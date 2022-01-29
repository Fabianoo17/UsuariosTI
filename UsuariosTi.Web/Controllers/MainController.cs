using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Corretora.Business.Interfaces;
using Corretora.Business.Security;
using Corretora.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corretora.App.Controllers
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