using UsuariosTi.Business.Entities;
using UsuariosTi.Business.ViewModels;
using System.Collections.Generic;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface IConsultarPrestadoresSIGOCService
    {

        IEnumerable<VW014_LISTA_PRESTADOR_SIGOC> BuscarPrestador(string pesquisaSIGOC);
        IEnumerable<VW016_RELATORIO_PRESTADORES> BuscarTecnicosTI(string pesquisaSIGOC);
        IEnumerable<VW016_RELATORIO_PRESTADORES> PrestadoresExcel();



    }
}
