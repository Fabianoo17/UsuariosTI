using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW002_PERCENTUAL_PROJETOS_ANO : Entity
    {
        [Key]
        public int CO_TIPO_PROJETO { get; set; }
        public string TIPO_PROJETO { get; set; }
        public int QTD_PROJETOS { get; set; }
        public decimal? PERCENTUAL { get; set; }
        public int ANO { get; set; }
    }
}
