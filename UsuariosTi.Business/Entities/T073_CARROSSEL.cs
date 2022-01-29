using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T073_CARROSSEL : Entity
    {
        [Key]
        public int NU_CARROSSEL { get; set; }

        public string NO_IMAGEM { get; set; }

        public int? NU_ORDENACAO { get; set; }

        public bool? IC_ATIVO { get; set; }
        public string TEXTO { get; set; }

        public byte[] IMAGEM { get; set; }

        public bool? BOTAO { get; set; }
        public string TEXTO_BOTAO { get; set; }
        public string TIPO_BOTAO { get; set; }
        public string LINK { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
    }
}
