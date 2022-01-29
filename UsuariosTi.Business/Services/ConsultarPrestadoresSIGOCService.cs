using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;

namespace UsuariosTi.Business.Services
{
    public class ConsultarPrestadoresSIGOCService : IConsultarPrestadoresSIGOCService

    {
        private readonly IVW014_LISTA_PRESTADOR_SIGOCRepository _vw014;
        private readonly IVW016_RELATORIO_PRESTADORESRepository _vw016;


        public ConsultarPrestadoresSIGOCService(
            IVW014_LISTA_PRESTADOR_SIGOCRepository vw014, 
            IVW016_RELATORIO_PRESTADORESRepository vw016)
        {
            _vw014 = vw014;
            _vw016 = vw016;
        }

        public IEnumerable<VW014_LISTA_PRESTADOR_SIGOC> BuscarPrestador(string pesquisaSIGOC)
        {
            pesquisaSIGOC = (pesquisaSIGOC + "").Replace("-", "").Replace(".", "").ToLower();
            var lista = _vw014.GetMany(x => (x.MATRICULA+"").ToLower(). Contains (pesquisaSIGOC)
           || (x.CPF+"").Replace(".", "").Replace("-", "").ToLower().Contains (pesquisaSIGOC)
           || (x.RG+"").Replace(".", "").Replace("-", "").ToLower(). Contains (pesquisaSIGOC)
           || (x.NOME+"").ToLower().Contains(pesquisaSIGOC));

            return lista;
        }

        public IEnumerable<VW016_RELATORIO_PRESTADORES> BuscarTecnicosTI(string pesquisaSIGOC)
        {
            pesquisaSIGOC = (pesquisaSIGOC + "").Replace("-", "").Replace(".", "").ToLower();
            var lista = _vw016.GetMany(x => (x.MATRICULA + "").ToLower().Contains(pesquisaSIGOC)
           || (x.CPF + "").Replace(".", "").Replace("-", "").ToLower().Contains(pesquisaSIGOC)
           || (x.RG + "").Replace(".", "").Replace("-", "").ToLower().Contains(pesquisaSIGOC)
           || (x.NOME + "").ToLower().Contains(pesquisaSIGOC));

            return lista;
        }

        public IEnumerable<VW016_RELATORIO_PRESTADORES> PrestadoresExcel()
        {
            var list = _vw016.GetMany(x => true);
            return list;
        }
    }
}
