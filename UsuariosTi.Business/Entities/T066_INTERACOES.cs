using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T066_INTERACOES : Entity
    {
        [Key]
        public int T066_ID { get; set; }

        public int? T065_ID { get; set; }

        public bool? T066_FLAG_CURTIR { get; set; }

        public string T066_USER_INTERACAO { get; set; }

        public DateTime? T066_DT_CADASTRO { get; set; }

        public bool? T066_FLAG_ATIVO { get; set; }
    }
}
