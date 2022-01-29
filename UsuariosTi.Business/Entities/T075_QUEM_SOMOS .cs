using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T075_QUEM_SOMOS : Entity
    {
        [Key]
        public int T075_CO_QUEM_SOMOS { get; set; }

        public int? T075_CO_CORDENACAO { get; set; }

        public string T075_NOME_BOTAO { get; set; }

    }
}
