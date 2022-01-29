using UsuariosTi.Business.Entities;
using System.Collections.Generic;

namespace UsuariosTi.Business.ViewModels
{
    public class ViewModelHome
    {
        public ViewModelHome()
        {
            ListaAbrangencia = new HashSet<T068_ABRANGENCIA>();
        }

        public VW001_RELATORIO_QTD_EMPREGADOS_CN_GI VW001_RELATORIO_QTD_EMPREGADOS_CN_GI { get; set; }

        public IEnumerable<T047_FERRAMENTA> T047_FERRAMENTAs { get; set; }
        public IEnumerable<VW002_PERCENTUAL_PROJETOS_ANO> VW002_PERCENTUAL_PROJETOS_ANOs { get; set; }
        public IEnumerable<VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETEC> VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECs { get; set; }
        public IEnumerable<VW005_RETRATO_TI_SERVICOS_REGIONAIS> VW005_RETRATO_TI_SERVICOS_REGIONAISs { get; set; }
        public IEnumerable<T068_ABRANGENCIA> ListaAbrangencia { get; set; }
        public IEnumerable<T074_ACESSO_RAPIDO_SITE> ListaQuemSomos { get; set; }


    }

}
