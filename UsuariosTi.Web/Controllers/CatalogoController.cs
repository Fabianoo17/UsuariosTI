using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsuariosTi.App.Controllers;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;

namespace UsuariosTi.Web.Controllers
{
    public class CatalogoController : MainController
    {
        private readonly ICatalogoService _catalogoservice;

        public CatalogoController(IUser user, ICatalogoService catalogoservice): base(user)
        {
            _catalogoservice = catalogoservice;
        }
   
        public IActionResult Index(string catalogo)
        {
            var lista = _catalogoservice.BuscarCatalogo(catalogo);
            return View(lista);
        }
    }
}
