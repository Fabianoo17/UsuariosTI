using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW007_CONSOLIDADO_PLANTONISTAS : Entity
    {
        [Key]
        public int? ID { get; set; }
        public int? CO_PLANTONISTA { get; set; }

        public string NOME_PLANTONISTA { get; set; }

        public int CO_DIA { get; set; }

        public DateTime? DIA { get; set; }

        public string COMPETENCIA { get; set; }

        public int CO_COORDENACAO_PLANTONISTA { get; set; }

        public string NOME { get; set; }

        public string FONE_SABADO { get; set; }

        public string FONE_DOMINGO { get; set; }
        [NotMapped]
        public string FONE_DOMINGO_FERIADO { get; set; }
        public string FONE_FERIADO { get; set; }

        public int? CGC_CENTRALIZADORA { get; set; }
        public int? ORDENCAO { get; set; }

    }
}