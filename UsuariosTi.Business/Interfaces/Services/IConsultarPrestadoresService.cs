using UsuariosTi.Business.Entities;
using UsuariosTi.Business.ViewModels;
using System.Collections.Generic;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface IConsultarPrestadoresService
    {

        IEnumerable<VW008_PRESTADORES_VITEC> BuscarPrestador(string pesquisa);

        
    }
}
