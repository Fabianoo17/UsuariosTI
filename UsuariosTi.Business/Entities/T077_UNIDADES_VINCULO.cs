using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T077_UNIDADES_VINCULO: Entity
    {
        [Key]
        public int T077_ID_UNIDADES_VINCULO { get; set; }

        public int? T077_CGC_FILIAL { get; set; }

        public string T077_SG_FILIAL { get; set; }

        public int? T077_CGC_UNIDADE { get; set; }

        public string T077_NO_UNIDADEL { get; set; }

        public bool? T002_ATIVO { get; set; }
    }
}
