using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T082_INTERACOES_ULTIMAS_ACOES: Entity
    {
        [Key]
        public int ID { get; set; }

        public int? T079_ID { get; set; }

        public string Matricula { get; set; }

        public bool? Positivo { get; set; }

        public bool? Negativo { get; set; }

        public bool? Visualizacao { get; set; }
    }
}
