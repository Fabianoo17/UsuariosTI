using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UsuariosTi.App.Controllers;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Enum;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels;

namespace UsuariosTi.Web.Controllers
{
    public class ReportagensTiController : MainController
    {
        private readonly IReportagensTiService _reportagensTiService;
        private readonly IHomeService _homeService;
        private readonly IUser _user;
        public ReportagensTiController(IUser user, 
                                       IReportagensTiService reportagensTiService,
                                       IHomeService homeService) : base(user)
        {
            _reportagensTiService = reportagensTiService;
            _homeService = homeService;
            _user = user;
        }

        public IActionResult ReportagensTi()
        {
            return View();
        }

        public IActionResult ListarReportagensTi(string textoFiltro)
        {
            var model = _reportagensTiService.ListarNoticiasDestaque(textoFiltro);

            return View(model);
        }

        public IActionResult DetalharReportagemTi(int idReportagem)
        {
            var matricula = UserCustom.Matricula;
            var model = _reportagensTiService.RetornaReportagemPorId(idReportagem, matricula);
            return View(model);
        }        
        
        public JsonResult AlteraVisualizacao(int idDicasTi)
        {
            var matricula = UserCustom.Matricula;
            _reportagensTiService.CadastraVisualizacao(matricula, idDicasTi);
            return Json(1);
        }        
        
        public JsonResult AlteraStatus(int idNotica, bool status)
        {
            var matricula = UserCustom.Matricula;

            _reportagensTiService.AlteraStatus(idNotica, matricula, status);

            var retorno = _reportagensTiService.countCurtir(idNotica, matricula, status);
            var retorno1 = _reportagensTiService.countCurtir(idNotica, matricula, !status);

            return Json(new { positivo = retorno, negativo = retorno1 });
        }
        
        public JsonResult CadastraComentario(int idDicasTi, string comentario)
        {
            var matricula = UserCustom.Matricula;
            _reportagensTiService.CadastraComentario(idDicasTi, matricula, comentario);
            return Json(1);
        }
        public JsonResult ContaComentarios(int idReportagem)
        {
            var count = _reportagensTiService.ContaComentarios(idReportagem);
            return Json(count);
        }

        public IActionResult DetalhaReportagem(int idReportagem)
        {
            ViewModelReportagensTi viewModel = new ViewModelReportagensTi();

            var matricula = UserCustom.Matricula;
            _reportagensTiService.CadastraVisualizacao(matricula, idReportagem);


            viewModel.VW012_LISTA_DICASTI = _reportagensTiService.DetalhaCarregaReportagem(idReportagem);
            viewModel.VW012_LISTA_DICASTIs = _reportagensTiService.RetornarTodasDicas(); 
            return View("_DetalharReportagem", viewModel);
        }

        public Image BinaryToImage(int Id)
        {
            var reportagem = _reportagensTiService.DetalhaCarregaReportagem(Id);

            MemoryStream ms = new MemoryStream(reportagem.T065_IMAG);
            Image img = Image.FromStream(ms);
            return img;
        }

        public FileResult BaixarImagem(int Id)
        {            
            var reportagem = _reportagensTiService.DetalhaCarregaReportagem(Id);
            return File(reportagem.T065_ANEXO, System.Net.Mime.MediaTypeNames.Application.Octet, reportagem.T065_NO_ANEXO);
        }

        public IActionResult DetalhaModalDicasTi(int idReportagem)
        {
            ViewModelReportagensTi viewModel = new ViewModelReportagensTi();
            _reportagensTiService.CadastraVisualizacao(_user.Matricula, idReportagem);

            viewModel.VW012_LISTA_DICASTI = _reportagensTiService.DetalhaCarregaReportagem(idReportagem);
            viewModel.VW012_LISTA_DICASTIs = _reportagensTiService.RetornarTodasDicas();
            return View(viewModel);
        }

        public JsonResult ContadorLikeDica(int id)
        {
            var valor = _reportagensTiService.ContadorLikeDica(id);
            return Json(valor);
        }

        public JsonResult ContadorDeslikeDica(int id)
        {
            var valor = _reportagensTiService.ContadorDeslikeDica(id);
            return Json(valor);
        }

        public JsonResult EnviarComentarioDicasTI(int id, string texto)
        {
            T081_COMENTARIOS comentario = new T081_COMENTARIOS();
            comentario.ID_Tipo_Indice = (int)EnumTipoComentario.DicasTi;
            comentario.ID_Dica_Acoes = id;
            comentario.Comentarios = texto;
            comentario.Matricula = _user.Matricula;
            comentario.Nome = _user.Nome;
            comentario.Data = DateTime.Now;
            comentario.Titulo_Email = BuscarTituloDicaTiPorID(id);
            _homeService.SalvarComentario(comentario);

            return Json("");


        }
        private string BuscarTituloDicaTiPorID(int idReportagem)
        {
            var item = _reportagensTiService.TituloDicas(idReportagem);

            return item.ToString();
        }



        public JsonResult BuscarComentariosDicasTI(int id) => Json(_homeService.ListarComentariosPorTipo(id, (int)EnumTipoComentario.DicasTi));
        


    }
}