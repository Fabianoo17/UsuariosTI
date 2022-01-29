using UsuariosTi.Business.Entities;
using System.Collections.Generic;

namespace UsuariosTi.Business.ViewModels
{
    public class ViewModelAcesso
    {
        public ViewModelAcesso()
        {
            
        }

        public IEnumerable<VW004_LISTA_USUARIO_ACESSO> VW004_LISTA_USUARIO_ACESSOs { get; set; }
    }
}
