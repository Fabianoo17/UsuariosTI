using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;

namespace UsuariosTi.Business.Services
{
    public class ConsultarPrestadoresService : IConsultarPrestadoresService

    {
        private readonly IVW008_PRESTADORES_VITECRepository _vw008;
        private readonly IVW016_RELATORIO_PRESTADORESRepository _vw016;

        public ConsultarPrestadoresService(IVW008_PRESTADORES_VITECRepository vw008)
        {
            _vw008 = vw008;
        }

        public IEnumerable<VW008_PRESTADORES_VITEC> BuscarPrestador(string pesquisa)
        {
            var lista = _vw008.GetMany(x => x.MATRICULA.ToLower() == pesquisa.ToLower()
           || x.CPF.Replace(".", "").Replace("-", "").ToLower() == pesquisa.Replace(".", "").Replace("-", "").ToLower()
           || x.RG.Replace(".", "").Replace("-", "").ToLower() == pesquisa.Replace(".", "").Replace("-", "").ToLower()
           || x.NOME.ToLower().Contains(pesquisa.ToLower()));

            return lista;
        }
           
    }
}
