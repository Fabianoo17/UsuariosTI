using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.ViewModels.Home.Corrossel;
using UsuariosTi.Business.ViewModels.Home.DicasTi;
using UsuariosTi.Business.ViewModels.Home.Numeros;
using UsuariosTi.Business.ViewModels.Home.QuemSomos;
using UsuariosTi.Business.ViewModels.Home.UltimasAcoes;

namespace UsuariosTi.Business.ViewModels.Home
{
    public class IndexViewModel
    {
        public CarrosselViewModel ModelCarrossel { get; set; }
        public QuemSomosViewModel ModelQuemSomos { get; set; }
        public NumerosViewModel ModelNumeros { get; set; }
        public ViewModelReportagensTi ModelDicasTi { get; set; }
        public IEnumerable<T079_ULTIMAS_ACOESViewModel> ModelUltimasAcoes { get; set; }

    }
}
