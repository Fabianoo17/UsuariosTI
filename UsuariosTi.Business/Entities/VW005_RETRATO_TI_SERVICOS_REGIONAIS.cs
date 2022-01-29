using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW005_RETRATO_TI_SERVICOS_REGIONAIS : Entity
    {
        [Key]
        public int? ID { get; set; }

        public int T048_ID_SERVICO { get; set; }

        public string NO_SERVICO { get; set; }

        public bool C_ATIVO { get; set; }

        public byte[] IMAGEM { get; set; }

        public int? T048_ID_ITEM_RETRATO { get; set; }

        public string T049_NO_SUBITEM_RETRATO { get; set; }

        public string T049_TIPAGEM { get; set; }

        public string T050_ID_INDICE_RETRATO { get; set; }

        public int? T049_ID_SUBITEM_RETRATO { get; set; }

        public string T050_COMPETENCIA { get; set; }

        public string T050_INDICE { get; set; }
        public string DATA_ATUALIZACAO { get; set; }
        public string ORIGEM { get; set; }
        public string ANO { get; set; }
        public string MES { get; set; }
        public string TITULO_SUBITEM { get; set; }
        public DateTime? ORDENACAO_DATA { get; set; }
        public int? T049_ORDENACAO { get; set; }

    }

}
