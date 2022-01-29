using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T055_COORDENACAO_PLANTONISTA : Entity
    {
        [Key]
        public int CO_COORDENACAO_PLANTONISTA { get; set; }
        public string NOME { get; set; }
        public string FONE_SABADO { get; set; }
        public string FONE_DOMINGO_FERIADO { get; set; }
        public int? CGC_CENTRALIZADORA { get; set; }
        public int? ORDENCAO { get; set; }

    }
}
