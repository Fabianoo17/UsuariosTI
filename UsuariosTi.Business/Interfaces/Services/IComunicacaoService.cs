using UsuariosTi.Business.Entities;
using UsuariosTi.Business.ViewModels;
using System.Collections.Generic;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface IComunicacaoService
    {
        IEnumerable<T039_DESTAQUE> CarregaDestaques();
        T039_DESTAQUE DetalhaCarregaDestaques(int idDestaque);

        void CadastraDestaques(T039_DESTAQUE destaque);
        void DeletarDestaques(int id);
        void AlterarDestaque(ViewModelT039_DESTAQUE viewModel);

        ViewModelT039_DESTAQUE BuscarDestaquePorId(int idDestaque);
    }
}
