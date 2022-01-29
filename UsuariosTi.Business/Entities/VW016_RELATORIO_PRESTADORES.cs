using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW016_RELATORIO_PRESTADORES : Entity
    {
        [Key]
        public long? ID { get; set; }

        public string NOME { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string ORGAO_EXPEDITOR { get; set; }

        public string MATRICULA { get; set; }

        public string EMPRESA { get; set; }

        public string CODIGO_UNIDADE_VALIDACAO { get; set; }

        public string SIGLA_UNIDADE { get; set; }

        public string USUARIO_ATIVO { get; set; }

        public string ORIGEM { get; set; }
    }
}
