using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW011_LISTA_COORDENACAO_PLANTONISTA : Entity
    {
        [Key]
        public int ID { get; set; }

        public int? CO_COORDENACAO_PLANTONISTA { get; set; }

        public string NOME { get; set; }

        public string FONE_SABADO { get; set; }

        public string FONE_DOMINGO_FERIADO { get; set; }

        public int? ORDENCAO { get; set; }

        public string NOME_EXIBICAO { get; set; }

        public string MAT { get; set; }

        public DateTime DT_CRIACAO { get; set; }

        public string CRIADOR { get; set; }

        public bool? IS_ATIVO { get; set; }

        public string TEL_PESSOAL { get; set; }

        public int? CO_PLANTONISTA { get; set; }

        public int? CGC_CENTRALIZADORA { get; set; }

    }
}
