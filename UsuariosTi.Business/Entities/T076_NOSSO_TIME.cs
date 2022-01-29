using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T076_NOSSO_TIME : Entity
    {
        [Key]
        public int T076_CO_DETALHA_NOSSO_TIME { get; set; }

        public string T076_MATRICULA     { get; set; }
        public string T076_NOME { get; set; }

        public string T076_TELEFONE { get; set; }

        public string T076_CARGO { get; set; }

        public Byte[] T076_FOTO { get; set; }

        public int? T076_ORDENACAO { get; set; }
        public string T076_GERENCIA { get; set; }

        public int? T076_POSICAO_QUADRO { get; set; }

    }
}
