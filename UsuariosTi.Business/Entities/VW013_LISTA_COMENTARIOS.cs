using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW013_LISTA_COMENTARIOS : Entity
    {
        [Key]
        public int T067_ID { get; set; }

        public int? T065_ID { get; set; }

        public string T067_COMENTARIO { get; set; }

        public string T067_USER_INTERACAO { get; set; }

        public DateTime? T067_DT_CADASTRO { get; set; }

        public bool? T067_FLAG_ATIVO { get; set; }

        public string NOME { get; set; }

    }
}
