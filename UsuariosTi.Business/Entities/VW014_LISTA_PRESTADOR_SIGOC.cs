using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW014_LISTA_PRESTADOR_SIGOC : Entity
    {
        [Key]
        public string NOME { get; set; }
        public string CPF { get; set; }

        public string RG { get; set; }

     
        public string MATRICULA { get; set; }

        public string FORNECEDOR { get; set; }

        public string UNIDADEVALIDACAO { get; set; }
        public string DEPARTAMENTO { get; set; }

        public string ATIVO { get; set; }
    }
}
