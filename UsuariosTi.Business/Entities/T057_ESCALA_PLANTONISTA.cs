using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T057_ESCALA_PLANTONISTA : Entity
    {
        [Key]
        public int CO_ESCALA { get; set; }

        public int CO_PLANTONISTA { get; set; }

        public DateTime? DIA { get; set; }

        public int? CO_COORDENACAO_PLANTONISTA { get; set; }

        public string MAT_ALTERACAO { get; set; }
        public DateTime? DT_ALTERACAO { get; set; }
    }
}
