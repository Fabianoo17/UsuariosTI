using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UsuariosTi.Business.Entities;

namespace UsuariosTi.Business.Entities
{
    public class T081_COMENTARIOS: Entity
    {
        [Key]
        public int ID { get; set; }

        public int? ID_Tipo_Indice { get; set; }

        public int? ID_Dica_Acoes { get; set; }

        public string Comentarios { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Titulo_Email { get; set; }        
       
    }
}
