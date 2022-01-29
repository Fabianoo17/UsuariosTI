using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T059_CENTRALIZADORAS : Entity
    {
        [Key]
        public int CO_CENTRALIZADORA { get; set; }

        public string SG_CENTRALIZADORA { get; set; }

        public int? CGC_CENTRALIZADORA { get; set; }
    }
}
