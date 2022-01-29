using UsuariosTi.Business.Entities;
using System.Collections.Generic;

namespace UsuariosTi.Business.ViewModels
{
    public class ViewModelReportagensTi
    {
        public ViewModelReportagensTi()
        {
            VW012_LISTA_DICASTIs = new HashSet<VW012_LISTA_DICASTI>();
            VW013_LISTA_COMENTARIOSs = new HashSet<VW013_LISTA_COMENTARIOS>();
            T066_INTERACOES = new T066_INTERACOES();
            T066_INTERACOESs = new HashSet<T066_INTERACOES>();
        }

        public IEnumerable<VW012_LISTA_DICASTI> VW012_LISTA_DICASTIs { get; set; }
        public IEnumerable<VW013_LISTA_COMENTARIOS> VW013_LISTA_COMENTARIOSs { get; set; }
        public VW012_LISTA_DICASTI VW012_LISTA_DICASTI { get; set; }
        public T066_INTERACOES T066_INTERACOES { get; set; }
        public IEnumerable<T066_INTERACOES> T066_INTERACOESs { get; set; }
     

    }
}
