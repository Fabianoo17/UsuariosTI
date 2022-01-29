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
    public class ConsultaTecnicoTIController : MainController
    {
        private readonly IConsultarPrestadoresSIGOCService _consultarservice;

        public ConsultaTecnicoTIController(IUser user,
                              IConsultarPrestadoresSIGOCService consultarservice) : base(user)
        {
            _consultarservice = consultarservice;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BuscarPrestadores(string pesquisa)
        {
            //var lista = _consultarservice.BuscarPrestador(pesquisa);
            var lista = _consultarservice.BuscarTecnicosTI(pesquisa);
            return View("_BuscarPrestadores", lista);
        }
    }
}
