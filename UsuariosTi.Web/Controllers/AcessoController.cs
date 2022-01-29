using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels;

namespace UsuariosTi.Web.Controllers
{
    public class AcessoController : Controller
    {
        private readonly IAcessoService _acessoService;
        public AcessoController(IAcessoService acessoService)
        {
            _acessoService = acessoService;
        }
        public IActionResult ManterAcesso()
        {
            ViewModelAcesso viewModel = new ViewModelAcesso();

            ViewBag.ListaPerfil = new SelectList(_acessoService.ListaPerfis(), "T002_ID_PERFIL", "T002_DESC_PERFIL");
            viewModel.VW004_LISTA_USUARIO_ACESSOs = _acessoService.ListaUsuariosComAcesso();

            return View(viewModel);
        }

        public IActionResult BuscaUsuarioPorMatricula(string matricula)
        {
            return Json(_acessoService.BuscaUsuario(matricula));
        }

        [HttpPost]
        public IActionResult CadastraUsuarioPerfil(string matricula, int idPerfil)
        {
            _acessoService.CadastraPerfil(matricula, idPerfil);
            return RedirectToAction("ManterAcesso", "Acesso");
        }

        
        public IActionResult DeletaUsuarioPerfil(int idUsuarioAcesso)
        {
            _acessoService.DeletarPerfil(idUsuarioAcesso);
            return Json(1);
        }
    }
}