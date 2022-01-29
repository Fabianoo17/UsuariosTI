using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T056_PLANTONISTAS : Entity
    {
        [Key]
        public int CO_PLANTONISTA { get; set; }
        public string NOME_EXIBICAO { get; set; }
        public string MAT { get; set; }
        public DateTime DT_CRIACAO { get; set; }
        public string CRIADOR { get; set; }
        public int? CGC_CENTRALIZADORA { get; set; }
        public bool IS_ATIVO { get; set; }
        public int? CO_COORDENACAO { get; set; }
        public string TEL_PESSOAL { get; set; }
       
    }
}
