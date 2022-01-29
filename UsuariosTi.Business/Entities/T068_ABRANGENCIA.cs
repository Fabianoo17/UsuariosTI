using System;
using System.ComponentModel.DataAnnotations;

namespace UsuariosTi.Business.Entities
{
    public class T068_ABRANGENCIA : Entity
    {
        [Key]
        public int T068_ID_ABRANGENCIA { get; set; }

        public string T068_PRODUTO { get; set; }

        public int? T068_QUANTITATIVO { get; set; }

        public DateTime? T068_DT_REGISTRO { get; set; }

        public string T068_COMPETENCIA { get; set; }

        public int? ID_ORDENACAO { get; set; }

        public string QTD => T068_QUANTITATIVO?.ToString("N0");

        public double raio => QTD.Length * 6 + 20;
        public double variacao => QTD.Length * -8;

    }
}
