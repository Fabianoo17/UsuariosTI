using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using UsuariosTi.App.Controllers;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels;
using System.Drawing;
using System.Net.Mime;

namespace UsuariosTi.Web.Controllers
{
    public class RelatorioPrestadoresController : MainController
    {
        private readonly IConsultarPrestadoresSIGOCService _consultarservice;

        public RelatorioPrestadoresController(IUser user,
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

        public IActionResult PrestadoresExcel()
        {
            var relatorio = _consultarservice.PrestadoresExcel();
            if (relatorio == null)
                return NotFound();

            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Relatório");
            workSheet.TabColor = System.Drawing.Color.Black;
            workSheet.DefaultRowHeight = 12;

            //Header of table
            workSheet.Row(1).Height = 20;
            workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;

            var vw016 = new ViewModelVW016_RELATORIO_PRESTADORES();

            workSheet.Cells[1, 1].Value = "NOME";
            workSheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 1].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 1].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 1].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            workSheet.Cells[1, 2].Value = "CPF";
            workSheet.Cells[1, 2].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 2].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 2].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 2].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 2].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            workSheet.Cells[1, 3].Value = "RG";
            workSheet.Cells[1, 3].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 3].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 3].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 3].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 3].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 3].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            workSheet.Cells[1, 4].Value = "ÓRGÃO EXPEDIDOR";
            workSheet.Cells[1, 4].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 4].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 4].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 4].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 4].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 4].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            workSheet.Cells[1, 5].Value = "MATRÍCULA";
            workSheet.Cells[1, 5].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 5].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 5].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 5].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 5].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 5].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            workSheet.Cells[1, 6].Value = "EMPRESA";
            workSheet.Cells[1, 6].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 6].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 6].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 6].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 6].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            workSheet.Cells[1, 7].Value = "CÓDIGO DA UNIDADE";
            workSheet.Cells[1, 7].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 7].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 7].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 7].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 7].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            workSheet.Cells[1, 8].Value = "SIGLA DA UNIDADE";
            workSheet.Cells[1, 8].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 8].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 8].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 8].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 8].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 8].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            workSheet.Cells[1, 9].Value = "USUÁRIO ATIVO";
            workSheet.Cells[1, 9].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 9].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 9].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 9].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 9].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 9].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            workSheet.Cells[1, 10].Value = "ORIGEM DOS DADOS";
            workSheet.Cells[1, 10].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 10].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 10].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 10].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            workSheet.Cells[1, 10].Style.Fill.PatternType = ExcelFillStyle.Solid;
            workSheet.Cells[1, 10].Style.Fill.BackgroundColor.SetColor(Color.CornflowerBlue);

            //Body of table 
            int recordIndex = 2;
            foreach (var item in relatorio)
            {
                workSheet.Cells[recordIndex, 1].Value = item.NOME;
                workSheet.Cells[recordIndex, 2].Value = item.CPF;
                workSheet.Cells[recordIndex, 3].Value = item.RG;
                workSheet.Cells[recordIndex, 4].Value = item.ORGAO_EXPEDITOR;
                workSheet.Cells[recordIndex, 5].Value = item.MATRICULA;
                workSheet.Cells[recordIndex, 6].Value = item.EMPRESA;
                workSheet.Cells[recordIndex, 7].Value = item.CODIGO_UNIDADE_VALIDACAO;
                workSheet.Cells[recordIndex, 8].Value = item.SIGLA_UNIDADE;
                workSheet.Cells[recordIndex, 9].Value = item.USUARIO_ATIVO;
                workSheet.Cells[recordIndex, 10].Value = item.ORIGEM;

                recordIndex++;
            }

            workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns();

            string excelName = $"Relatório Prestadores {DateTime.Now.ToString("dd-MM-yyyy")}.xlsx";
            byte[] filecontent = excel.GetAsByteArray();

            return File(filecontent, MediaTypeNames.Application.Octet, excelName);

        }
    }
}
