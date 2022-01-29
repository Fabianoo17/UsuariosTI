using UsuariosTi.Business.Entities;
using UsuariosTi.Business.ViewModels;
using System.Collections.Generic;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface IHistoricoService
    {
        VW001_RELATORIO_QTD_EMPREGADOS_CN_GI RelatorioQtdEmpregados();

        IEnumerable<T047_FERRAMENTA> ListaFerramentas();
        IEnumerable<VW002_PERCENTUAL_PROJETOS_ANO> RelatorioPercentualPlanejamentoProjeto();
        IEnumerable<VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETEC> RelatorioPercentualDesempenhoCetec();
        IEnumerable<VW008_PRESTADORES_VITEC> BuscarPrestador(string pesquisa);
        IEnumerable<T068_ABRANGENCIA> ListaAbrangencia();
        
        
    }
}
