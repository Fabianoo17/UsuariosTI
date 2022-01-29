using System;
using System.Collections.Generic;
using System.Text;

namespace Corretora.Business.Entities
{
    public class diectvw006_willis_rural_visao : Entity
    {
        public string sifec { get; set; }

        public string status { get; set; }

        public string status_grafico { get; set; }

        public string seguradora { get; set; }

        public string ramo { get; set; }

        public string ramo_grafico { get; set; }

        public string produto { get; set; }

        public string produto_grafico { get; set; }

        public int? qtd { get; set; }

        public decimal? premio { get; set; }

        public decimal? valor_comissao_willis { get; set; }

        public decimal? valor_comissao_caixa { get; set; }

        public DateTime? data { get; set; }

        public string mes_referencia { get; set; }

        public string data_grafico { get; set; }

        public int? ano { get; set; }

        public string mes { get; set; }

        public int? unidade_venda { get; set; }

        public string nu_sr { get; set; }

        public string nome_sr { get; set; }

        public string nu_regiao { get; set; }

        public string regiao { get; set; }

        public DateTime? dt_carga { get; set; }

    }
}
