using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETEC : Entity
    {
        [Key]
        public int ID { get; set; }
        public int ID_PROCESSO { get; set; }
        public string NO_PROCESSO { get; set; }
        public decimal? IND_PROCESSO { get; set; }
        public decimal? META_PROCESSO { get; set; }
        public int MES { get; set; }
        public int ANO { get; set; }
    }
}
