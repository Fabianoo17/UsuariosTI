using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T061_TELEFONE_MODULO_PLANTONISTA : Entity
    {
        [Key]
        public int CO_TELEFONES { get; set; }

        public string DESC_TELEFONE { get; set; }

        public string TELEFONE1 { get; set; }

        public string TELEFONE2 { get; set; }

        public string TIPO { get; set; }

        public int? CGC_CENTRALIZADORA { get; set; }
    }
}
