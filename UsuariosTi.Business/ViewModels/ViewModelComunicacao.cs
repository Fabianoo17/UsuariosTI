using UsuariosTi.Business.Entities;
using System.Collections.Generic;

namespace UsuariosTi.Business.ViewModels
{
    public class ViewModelComunicacao
    {
        public ViewModelComunicacao()
        {
            
        }

        public IEnumerable<T039_DESTAQUE> T039_DESTAQUEs { get; set; }
        public T039_DESTAQUE T039_DESTAQUE { get; set; }
    }
}
