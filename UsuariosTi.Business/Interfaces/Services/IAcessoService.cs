using UsuariosTi.Business.Entities;
using UsuariosTi.Business.ViewModels;
using System.Collections.Generic;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface IAcessoService
    {
        IEnumerable<T002_PERFIL> ListaPerfis();
        IEnumerable<VW004_LISTA_USUARIO_ACESSO> ListaUsuariosComAcesso();
        VW000_USUARIOS BuscaUsuario(string matricula);
        void CadastraPerfil(string matricula, int idPerfil);
        void DeletarPerfil(int id);
    }
}
