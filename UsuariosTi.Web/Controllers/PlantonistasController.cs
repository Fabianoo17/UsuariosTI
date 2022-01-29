using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels;

namespace UsuariosTi.Web.Controllers
{
    public class PlantonistasController : Controller
    {
        private readonly IPlantonistaService _plantonista;
        public PlantonistasController(IPlantonistaService plantonista)
        {
            _plantonista = plantonista;
        }
        public IActionResult Index(int? ano, int? mes, int? centralizadora)
        {
            return Redirect("http://plantonistas.usuariosti.caixa/Plantonistas");
            //var model = new ViewModelPlantonistas();
            //model.coordenacaoUser = _plantonista.CoordenacaoUser();
            //var centralizadoras = _plantonista.ListaCentralizadoras();
            //ViewBag.Centralizadoras = new SelectList(centralizadoras, "CGC_CENTRALIZADORA", "SG_CENTRALIZADORA");

            //model.Mes = mes;
            //model.Ano = ano;
            //model.Centralizadora = centralizadora;

            //if (mes == null) model.Mes = DateTime.Now.Month;
            //if (centralizadora == null) model.Centralizadora = centralizadoras.FirstOrDefault().CGC_CENTRALIZADORA;
            //if (ano == null) model.Ano = DateTime.Now.Year;
            //model.ListaTelefones = _plantonista.ListaTelefones(model.Centralizadora);
            //model.Plantonistas = _plantonista.Plantonistas(model.Ano, model.Mes, model.Centralizadora);
            //ViewBag.Meses = new SelectList(model.Meses, "ID", "Mes");

            //return View(model);
        }
        public IActionResult PesquisarUsuarios(string matriculaOuNome)
        {
            var usuarios = _plantonista.PesquisarUsuarios(matriculaOuNome);
            var usuariosSelect = usuarios.Select(x => new { id = x.MATRICULA, text = $"{x.NOME} - {x.MATRICULA}" }).ToList();

            return Json(new { results = usuariosSelect });
        }


        public IActionResult Admin(int? ano, int? mes, int? centralizadora)
        {
            var model = new ViewModelPlantonistas();
        
            model.Mes = mes;
            model.Ano = ano;
            model.Centralizadora = centralizadora;
            model.coordenacaoUser = _plantonista.CoordenacaoUser();
         



            if (mes == null) model.Mes = DateTime.Now.Month;
            if (ano == null) model.Ano = DateTime.Now.Year;
            model.Plantonistas = _plantonista.Plantonistas(model.Ano, model.Mes, centralizadora);
            model.ListaPlantonistas = _plantonista.ListaPlantonistas(centralizadora);
            model.ListaPlantonistasCoordenacao = _plantonista.ListaPlantonistasCoordenacao(null);

            ViewBag.plantonistas = new SelectList(model.ListaPlantonistas.Where(x => x.IS_ATIVO), "CO_PLANTONISTA", "NOME_EXIBICAO");
            ViewBag.plantonistasGeral = new SelectList(model.ListaPlantonistas.Where(x => x.IS_ATIVO), "CO_PLANTONISTA", "NOME_EXIBICAO");
            ViewBag.DropdownUsuarios = new SelectList(new List<dynamic>());
            ViewBag.Centralizadoras = new SelectList(_plantonista.ListaCentralizadoras(), "CGC_CENTRALIZADORA", "SG_CENTRALIZADORA");
            ViewBag.Coordenacao = new SelectList(_plantonista.PesquisarCoordenacao(), "CO_COORDENACAO_PLANTONISTA", "NOME");
            //model.Centralizadora = _plantonista.ListaCentralizadoras();

            //return View("~UsuariosTi.Web/Views/Plantonistas/_ListaPlantonistas.cshtml");

            return View(model);
        }

        public IActionResult AtualizarPlantonista(T056_PLANTONISTAS plantonista)
        {

            try
            {
                _plantonista.AtualizarPlantonista(plantonista);
                return Json(new
                {
                    mensagem = "Plantonista Atualizado com Sucesso!",
                    success = true
                });
            }
            catch
            {
                return Json(new
                {
                    success = false
                });
            }

        }

        public IActionResult AdicionarPlantonista(T056_PLANTONISTAS plantonista)
        {
            var result = _plantonista.AdicionarPlantonista(plantonista);
            return Json(new
            {
                success = result
            });

        }



        public IActionResult AdicionarAtualizarEscala(T057_ESCALA_PLANTONISTA model)
        {
            var result = _plantonista.AdicionarAtualizarEscalar(model);
            return Json(new
            {
                success = result
            });
        }

        public IActionResult AdicionarDiaPlantonista(T054_DIA_PLANTONISTA model)
        {
            var result = _plantonista.AdicionarDiaPlantonista(model);
            return Json(new
            {
                success = result
            });
        }
        public IActionResult ExcluirDiaPlantonista(int id)
        {
            var result = _plantonista.ExcluirDiaPlantonista(id);
            return Json(new
            {
                success = result
            });
        }


        public IActionResult ListaPlantonistas(int centralizadora)
        {

            var model = new ViewModelPlantonistas();

            model.ListaPlantonistasCoordenacao = _plantonista.ListaPlantonistasCoordenacaoPorCentralizadora(centralizadora);
            return View("_ListaPlantonistas", model);
        }

        public IActionResult ListarDias(int centralizadora, int ano, int mes)
        {
       

            var lista = _plantonista.DiasPlantonistas(ano, mes, centralizadora);


            return View("_ListarDias", lista);
        }

        public IActionResult ExcluirPlantonista(int id)
        {
            var result = _plantonista.ExcluirPlantonista(id);
            return Json(new
            {
                success = result
            });
        }
    }



}
