using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T065_DICAS_TI : Entity
    {
        [Key]
        public int T065_ID { get; set; }

        public string T065_TITULO { get; set; }

        public string T065_TEXTO { get; set; }

        public string T065_BREVE_DESCRICAO { get; set; }

        public DateTime? T065_DT_CADASTRO { get; set; }

        public string T065_USER_CADASTRO { get; set; }

        public byte[] T065_IMAG { get; set; }

        public bool? T065_FLAG_ATIVO { get; set; }
        public int? T065_POSITIVO { get; set; }
        public int? T065_NEGATIVO { get; set; }
        public int? T065_VISUALIZACAO { get; set; }
        public string T065_NO_IMAGEM { get; set; }

        public string T065_MATRICULA { get; set; }
        public string T065_NOME { get; set; }

        public byte[] T065_ANEXO { get; set; }
        public string T065_NO_ANEXO { get; set; }
    }
}
