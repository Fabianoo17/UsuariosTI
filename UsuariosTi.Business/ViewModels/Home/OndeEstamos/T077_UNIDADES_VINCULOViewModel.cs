using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Business.ViewModels.Home.OndeEstamos
{
    public class T077_UNIDADES_VINCULOViewModel
    {
        public int T077_ID_UNIDADES_VINCULO { get; set; }

        public int? T077_CGC_FILIAL { get; set; }

        public string T077_SG_FILIAL { get; set; }

        public int? T077_CGC_UNIDADE { get; set; }

        public string T077_NO_UNIDADEL { get; set; }

        public bool? T002_ATIVO { get; set; }
        public string Texto { get; set; }
        public string Link { get; set; }
    }
}
