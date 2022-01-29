using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsuariosTi.App.Controllers;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels;

namespace UsuariosTi.Web.Controllers
{
    public class ComunicacaoController : MainController
    {
        private readonly IComunicacaoService _comunicacaoService;

        public ComunicacaoController(IUser user,
                                    IComunicacaoService comunicacaoService) : base(user)
        {
            _comunicacaoService = comunicacaoService;
        }

        [HttpGet]
        public IActionResult CadastroComunicacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroComunicacao(T039_DESTAQUE model)
        {
            _comunicacaoService.CadastraDestaques(model);

            return RedirectToAction("ListaComunicacao", "Comunicacao");
        } 
        
        [HttpGet]
        public IActionResult AlterarComunicacao(int idDestaque)
        {
            ViewModelT039_DESTAQUE t039_destaque = _comunicacaoService.BuscarDestaquePorId(idDestaque);
            return View(t039_destaque);
        }

        [HttpPost]
        public IActionResult AlterarComunicacao(ViewModelT039_DESTAQUE model)
        {
            _comunicacaoService.AlterarDestaque(model);

            return RedirectToAction("ListaComunicacao", "Comunicacao");
        }

        public IActionResult ListaComunicacao()
        {
            ViewModelComunicacao viewModel = new ViewModelComunicacao();

            viewModel.T039_DESTAQUEs = _comunicacaoService.CarregaDestaques();
            return View(viewModel);
        }

        public IActionResult CarrosselComunicacao()
        {
            ViewModelComunicacao viewModel = new ViewModelComunicacao();

            viewModel.T039_DESTAQUEs = _comunicacaoService.CarregaDestaques();
            return View(viewModel);
        }

        public IActionResult DeleteComunicacao(int id)
        {
            _comunicacaoService.DeletarDestaques(id);
            return RedirectToAction("ListaComunicacao");

        }

        public IActionResult BlocosComunicacao()
        {
            ViewModelComunicacao viewModel = new ViewModelComunicacao();

            viewModel.T039_DESTAQUEs = _comunicacaoService.CarregaDestaques();
            return View(viewModel);
        }

        public IActionResult DetalhaBlocosComunicacao(int idDestaque)
        {
            ViewModelComunicacao viewModel = new ViewModelComunicacao();

            viewModel.T039_DESTAQUE = _comunicacaoService.DetalhaCarregaDestaques(idDestaque);
            return View("_DetalhaBlocoComunicacao", viewModel);
        }
    }
}