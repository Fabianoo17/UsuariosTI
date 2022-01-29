using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuariosTi.Business.Entities
{
   public class T072_PRESTADOR_SIGOC : Entity
    {
        public string NOME { get; set; }
        [Key]
        public string CPF { get; set; }

        public string RG { get; set; }

        public string MATRICULA { get; set; }

        public string FORNECEDOR { get; set; }

        public string UNIDADEVALIDACAO { get; set; }
        public string ATIVO { get; set; }
    }
}
