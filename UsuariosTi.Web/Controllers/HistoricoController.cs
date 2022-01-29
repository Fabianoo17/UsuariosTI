using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels;
using System;
using System.IO;
using System.Linq;
using System.Drawing;
using OfficeOpenXml.Style;


using System.Data.SqlClient;
using System.Data;
using UsuariosTi.Data.Procedure;

namespace UsuariosTi.App.Controllers
{
    public class HistoricoController : MainController
    {
        private readonly IHistoricoService _homeService;

        public HistoricoController(IUser user,
                              IHistoricoService homeService) : base(user)
        {
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            ViewModelHome viewModel = new ViewModelHome();

            viewModel.T047_FERRAMENTAs = _homeService.ListaFerramentas();
            viewModel.VW001_RELATORIO_QTD_EMPREGADOS_CN_GI = _homeService.RelatorioQtdEmpregados();
            viewModel.VW002_PERCENTUAL_PROJETOS_ANOs = _homeService.RelatorioPercentualPlanejamentoProjeto();
            viewModel.VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECs = _homeService.RelatorioPercentualDesempenhoCetec();
            viewModel.ListaAbrangencia = _homeService.ListaAbrangencia();

            return View(viewModel);
        }

        public IActionResult BuscarNoticia()
        {
            return View();
        }
  
        public IActionResult ConsultaTecnicoTI()
        {

            return View();
        }

        public IActionResult BuscarPrestadores(string pesquisa)
        {
            var lista = _homeService.BuscarPrestador(pesquisa);

            return View("_BuscarPrestadores",lista);
        }

    }
}
