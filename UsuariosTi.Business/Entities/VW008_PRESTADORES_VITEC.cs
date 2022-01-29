using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW008_PRESTADORES_VITEC : Entity
    {
        public string NOME { get; set; }
        [Key]
        public string CPF { get; set; }

        public string RG { get; set; }

        public string ORGAO_EXPEDITOR { get; set; }

        public string MATRICULA { get; set; }

        public string EMPRESA { get; set; }

        public string CODIGO_UNIDADE_VALIDACAO { get; set; }
        public string SIGLA_UNIDADE { get; set; }

        public string USUARIO_ATIVO { get; set; }

    }
}
