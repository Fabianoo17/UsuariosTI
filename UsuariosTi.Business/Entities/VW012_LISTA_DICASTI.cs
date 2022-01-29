using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW012_LISTA_DICASTI : Entity
    {
        [Key]
        public int T065_ID { get; set; }

        public string T065_TITULO { get; set; }

        public string T065_TEXTO { get; set; }

        public string T065_BREVE_DESCRICAO { get; set; }

        public DateTime? T065_DT_CADASTRO { get; set; }

        public string T065_USER_CADASTRO { get; set; }

        public byte[] T065_IMAG { get; set; }

        public int? QTD_CURTIR { get; set; }

        public int? QTD_DESCURTIR { get; set; }
        
        public int? QTD_COMENTARIOS { get; set; }

        public int? QTD_VISUALIZACAO { get; set; }
        public int? T065_POSITIVO { get; set; }
        public int? T065_NEGATIVO { get; set; }
        public int? T065_VISUALIZACAO { get; set; }

        public byte[] T065_ANEXO { get; set; }

        public string T065_NO_ANEXO { get; set; }


    }
}
