using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T054_DIA_PLANTONISTA : Entity
    {
        [Key]
        public int CO_DIA { get; set; }

        public DateTime? DIA { get; set; }

        public string COMPETENCIA { get; set; }

        public string UNIDADE { get; set; }

    }
}
