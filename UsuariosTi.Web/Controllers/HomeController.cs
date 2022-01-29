using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using UsuariosTi.App.Controllers;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels;
using UsuariosTi.Business.ViewModels.Home;
using UsuariosTi.Business.ViewModels.Home.Corrossel;
using UsuariosTi.Business.ViewModels.Home.DicasTi;
using UsuariosTi.Business.ViewModels.Home.OndeEstamos;
using UsuariosTi.Business.ViewModels.Home.UltimasAcoes;
using UsuariosTi.Data.Procedure;

namespace UsuariosTi.Web.Controllers
{
    public class HomeController : MainController
    {

        private readonly IUser _user;
        private readonly IHomeService _homeService;

        public HomeController(IUser user,
                              IHomeService homeService) : base(user)
        {
            _user = user;
            _homeService = homeService;
        }

        public IActionResult Index(string pesquisa)
        {
            return View(_homeService.PopularIndexModel(pesquisa));
        }


        public IActionResult ChamarModaisDetalhamentoQuemSomos(int? idModal)
        {
            switch (idModal)
            {
                case 1:
                    return View("NossoTime", _homeService.ListarNossoTime());
                case 2:
                    return View("ModalExperienciaDoUsuario");
                case 3:
                    return View("ModalCanais");
                case 4:
                    return View("ModalServiceDesk");
                case 5:
                    return View("ModalColabSoftware");
                default:
                    return null;
            }
        }

        public IActionResult NossoTime()
        {
            var dados = _homeService.ListarNossoTime();
            return View(dados);
        }

        public IActionResult OndeEstamos()
        {
            var dados = _homeService.GetUnidadeVinculo(int.Parse(_user.UnidadeCodigo));
            //var dados = _homeService.GetUnidadeVinculo(4520);
            //var dados = _homeService.GetUnidadeVinculo(7562);
            var txt = _homeService.GetTexto(dados.T077_SG_FILIAL);

            var model = new T077_UNIDADES_VINCULOViewModel();
            model.T077_ID_UNIDADES_VINCULO = dados.T077_ID_UNIDADES_VINCULO;
            model.T077_CGC_FILIAL = dados.T077_CGC_FILIAL;
            model.T077_SG_FILIAL = dados.T077_SG_FILIAL;
            model.T077_CGC_UNIDADE = dados.T077_CGC_UNIDADE;
            model.T077_NO_UNIDADEL = dados.T077_NO_UNIDADEL;
            model.T002_ATIVO = dados.T002_ATIVO;
            model.Texto = txt.Texto;
            model.Link = txt.Link;

            return View("_OndeEstamosInt", model);
        }

        public IActionResult OndeEstamosMapa(int id)
        {

            var dados = _homeService.GetUnidade(id);
            var txt = _homeService.GetTexto(dados.T077_SG_FILIAL);

            var model = new T077_UNIDADES_VINCULOViewModel();
            model.T077_ID_UNIDADES_VINCULO = dados.T077_ID_UNIDADES_VINCULO;
            model.T077_CGC_FILIAL = dados.T077_CGC_FILIAL;
            model.T077_SG_FILIAL = dados.T077_SG_FILIAL;
            model.T077_CGC_UNIDADE = dados.T077_CGC_UNIDADE;
            model.T077_NO_UNIDADEL = dados.T077_NO_UNIDADEL;
            model.T002_ATIVO = dados.T002_ATIVO;
            model.Texto = txt.Texto;
            model.Link = txt.Link;

            return View("_OndeEstamosInt", model);
        }

        public IActionResult Ferramentas()
        {
            var model = _homeService.ListarFerramentas(1);

            return View("_Ferramentas", model);
        }

        public JsonResult ContadorLike(int id)
        {
            var valor = _homeService.ContadorLike(id);
            return Json(valor);
        }

        public JsonResult ContadorDeslike(int id)
        {
            var valor = _homeService.ContadorDeslike(id);
            return Json(valor);
        }

        public JsonResult ContadorVisualizacao(int id)
        {
            var dados = _homeService.ContadorVisualizar(id);
            var comentarios = _homeService.ListarComentarios(id);

            T079_ULTIMAS_ACOESViewModel model = new T079_ULTIMAS_ACOESViewModel();
            model.ID = dados.ID;
            model.Titulo = dados.Titulo;
            model.Data = dados.Data;
            model.Caminho = dados.Caminho;
            model.Video = dados.Video;
            model.Resumo = dados.Resumo;
            model.Texto = dados.Texto;
            model.Positivo = dados.Positivo;
            model.Negativo = dados.Negativo;
            model.Visualizacao = dados.Visualizacao;
            model.ListarComentarios = comentarios;

            return Json(model);
        }

        public JsonResult TodasAcoes()
        {
            var dados = _homeService.ListarUltimasAcoes(0);           
            return Json(dados);
        }

        public JsonResult EnviarComentario(int id, string texto)
        {

            T081_COMENTARIOS comentario = new T081_COMENTARIOS();
            comentario.ID_Tipo_Indice = 2;
            comentario.ID_Dica_Acoes = id;
            comentario.Comentarios = texto;
            comentario.Matricula = _user.Matricula;
            comentario.Nome = _user.Nome;
            comentario.Data = DateTime.Now;
            comentario.Titulo_Email = BuscarTituloUltimasAcoesPorID(id);

            _homeService.SalvarComentario(comentario);

            var dados = _homeService.ContadorVisualizar(id);
            var comentarios = _homeService.ListarComentarios(id);

            T079_ULTIMAS_ACOESViewModel model = new T079_ULTIMAS_ACOESViewModel();
            model.ID = dados.ID;
            model.Titulo = dados.Titulo;
            model.Data = dados.Data;
            model.Caminho = dados.Caminho;
            model.Video = dados.Video;
            model.Resumo = dados.Resumo;
            model.Texto = dados.Texto;
            model.Positivo = dados.Positivo;
            model.Negativo = dados.Negativo;
            model.Visualizacao = dados.Visualizacao;
            model.ListarComentarios = comentarios;

            return Json(model);
        }

        private string BuscarTituloUltimasAcoesPorID(int id)
        {
            var item = _homeService.ContadorVisualizar(id);

            return item.Titulo;
        }

        public JsonResult FaleConosco(string texto)
        {

            T081_COMENTARIOS comentario = new T081_COMENTARIOS();
            comentario.ID_Tipo_Indice = 3;
            comentario.ID_Dica_Acoes = null;
            comentario.Comentarios = texto;
            comentario.Matricula = _user.Matricula;
            comentario.Nome = _user.Nome;
            comentario.Data = DateTime.Now;
            comentario.Titulo_Email = ' '.ToString();

            _homeService.SalvarComentario(comentario);

            return Json(comentario);
        }

        public JsonResult FaleConoscoDicaTi(string texto)
        {

            T081_COMENTARIOS comentario = new T081_COMENTARIOS();
            comentario.ID_Tipo_Indice = 4;
            comentario.ID_Dica_Acoes = null;
            comentario.Comentarios = texto;
            comentario.Matricula = _user.Matricula;
            comentario.Nome = _user.Nome;
            comentario.Data = DateTime.Now;
            comentario.Titulo_Email = ' '.ToString();
            _homeService.SalvarComentarioDicaTi(comentario);

            return Json(comentario);
        }

        public IActionResult RetratoTI()
        {
            ViewModelHome viewModel = new ViewModelHome();

            viewModel.VW005_RETRATO_TI_SERVICOS_REGIONAISs = _homeService.RelatorioUsuariosTi();
            ViewBag.DataAtualizacao = _homeService.DataAtualizacao();

            return View(viewModel);
        }
        public IActionResult GerarExcelRetratoDaTI()
        {
            //var list = _homeService.RelatorioUsuariosTiExcel();

            var list = new P082_RETRATO_TI_SERVICOS_REGIONAIS().RetornarDadosComoDT();
            string excelName = $"Retrato da TI - GN Serviços Regionais TI-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            string export = "Anual";

            byte[] fileContents;
            using (var package = new ExcelPackage())
            {
                Color colFromHex = System.Drawing.ColorTranslator.FromHtml("#B7DEE8");
                var worksheet = package.Workbook.Worksheets.Add(export);
                worksheet.Cells["A1"].LoadFromDataTable(list, true);
                worksheet.SelectedRange["A1:N1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.SelectedRange["A1:N1"].Style.Fill.BackgroundColor.SetColor(colFromHex);
                fileContents = package.GetAsByteArray();
            }
            if (fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }
            return File(
                fileContents: fileContents,
                contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileDownloadName: excelName
            );

        }

        public JsonResult ListarUltimasAcoes()
        {
            var list = _homeService.ListarUltimasAcoes(0);
            return Json(list);
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public JsonResult SalvarUltimasAcoes(T079_ULTIMAS_ACOESViewModel model)
        {

            if(model.ID == 0)
            {
                _homeService.SalvarUltimasAcoes(model);
            } else
            {
                _homeService.UpdateUltimasAcoes(model);
            }

            return Json(new { tipo = "Listar" });
        }

        [HttpPost]
        public JsonResult EditarUltimasAcoes(int id)
        {
            var dados = _homeService.EditarUltimasAcoes(id);
            return Json(dados);
        }

        [HttpDelete]
        public JsonResult DeletarUltimasAcoes(int id)
        {
            _homeService.DeleteUltimasAcoes(id);
            return Json(new { tipo = "Delete" });
        }

        public JsonResult ListarDicasTI()
        {
            var list = _homeService.ListarDicasTI();
            return Json(list);
        }

        [HttpPost]
        public JsonResult SalvarCards(T065_DICAS_TIViewModel model)
        {

            if (model.T065_ID == 0)
            {
                _homeService.SalvarDicasTI(model);
            }
            else
            {
                _homeService.UpdateDicasTI(model);
            }

            return Json(new { tipo = "Listar" });
        }

        [HttpPost]
        public JsonResult EditarCards(int id)
        {
            var dados = _homeService.EditarDicasTI(id);
            return Json(dados);
        }

        [HttpDelete]
        public JsonResult DeletarCards(int id)
        {
            _homeService.DeleteDicasTI(id);
            return Json(new { tipo = "Delete" });
        }

        public JsonResult ListarCarousel()
        {
            var list = _homeService.ListarCarousel();
            return Json(list);
        }

        [HttpPost]
        public JsonResult SalvarCarousel(CarrosselViewModel model)
        {

            if (model.NU_CARROSSEL == 0)
            {
                _homeService.SalvarCarousel(model);
            }
            else
            {
                _homeService.UpdateCarousel(model);
            }

            return Json(new { tipo = "Listar" });
        }

        [HttpPost]
        public JsonResult EditarCarousel(int id)
        {
            var dados = _homeService.EditarCarousel(id);
            return Json(dados);
        }

        [HttpDelete]
        public JsonResult DeletarCarousel(int id)
        {
            _homeService.DeleteCarousel(id);
            return Json(new { tipo = "Delete" });
        }

    }
}