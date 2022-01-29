using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.ViewModels
{
    public class ViewModelVW016_RELATORIO_PRESTADORES
    {

        public int ID { get; set; }

        [Display(Name = "NOME")]
        public string NOME { get; set; }

        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "RG")]
        public string RG { get; set; }

        [Display(Name = "ORGÃO EXPEDITOR")]
        public string ORGAO_EXPEDITOR { get; set; }

        [Display(Name = "MATRÍCULA")]
        public string MATRICULA { get; set; }

        [Display(Name = "EMPRESA")]
        public string EMPRESA { get; set; }

        [Display(Name = "CÓDIGO UNIDADE")]
        public string CODIGO_UNIDADE_VALIDACAO { get; set; }

        [Display(Name = "SIGLA UNIDADE")]
        public string SIGLA_UNIDADE { get; set; }

        [Display(Name = "USUÁRIO ATIVO")]
        public string USUARIO_ATIVO { get; set; }

        [Display(Name = "ORIGEM DOS DADOS")]
        public string ORIGEM { get; set; }
    }
}

