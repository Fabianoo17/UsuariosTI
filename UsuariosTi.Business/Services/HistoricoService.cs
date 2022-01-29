using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UsuariosTi.Business.Services
{
    public class HistoricoService : IHistoricoService
    {

        private readonly IT047_FERRAMENTARepository _t047;
        private readonly IT052_PRESTADORES_SCPRepository _t052;
        private readonly IT068_ABRANGENCIARepository _t068;
        private readonly IVW001_RELATORIO_QTD_EMPREGADOS_CN_GIRepository _vw001;
        private readonly IVW002_PERCENTUAL_PROJETOS_ANORepository _vw002;
        private readonly IVW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECRepository _vw003;
        private readonly IVW005_RETRATO_TI_SERVICOS_REGIONAISRepository _vw005;
        private readonly IVW008_PRESTADORES_VITECRepository _vw008;
        private readonly IT071_CATALOGO_SERVICORepository _t071;
        private readonly IT072_PRESTADOR_SIGOCRepository _t072;
        private readonly IVW014_LISTA_PRESTADOR_SIGOCRepository _vw014;

        public HistoricoService(IT047_FERRAMENTARepository t047,
                            IVW001_RELATORIO_QTD_EMPREGADOS_CN_GIRepository vw001,
                            IVW002_PERCENTUAL_PROJETOS_ANORepository vw002,
                            IVW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECRepository vw003,
                            IVW005_RETRATO_TI_SERVICOS_REGIONAISRepository vw005,
                            IVW008_PRESTADORES_VITECRepository vw008,
                            IT052_PRESTADORES_SCPRepository t052,
                            IT068_ABRANGENCIARepository t068,
                            IT071_CATALOGO_SERVICORepository t071,
                            IT072_PRESTADOR_SIGOCRepository t072,
                            IVW014_LISTA_PRESTADOR_SIGOCRepository vw014)
        {
            _t047 = t047;
            _vw008 = vw008;
            _vw001 = vw001;
            _vw002 = vw002;
            _vw003 = vw003;
            _vw005 = vw005;
            _t052 = t052;
            _t068 = t068;
            _t071 = t071;
            _t072 = t072;
            _vw014 = vw014;
        }

        public IEnumerable<T047_FERRAMENTA> ListaFerramentas()
        {
            var list = _t047.GetMany(x => true);
            return list;
        }
        public IEnumerable<T068_ABRANGENCIA> ListaAbrangencia()
        {
            var list = _t068.GetMany(x =>x.T068_COMPETENCIA == DateTime.Now.AddMonths(-1).ToString("MM/yyyy"));
            return list;
        }

        public IEnumerable<VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETEC> RelatorioPercentualDesempenhoCetec()
        {
            var list = _vw003.GetMany(x => true);
            return list;
        }

        public IEnumerable<VW002_PERCENTUAL_PROJETOS_ANO> RelatorioPercentualPlanejamentoProjeto()
        {
            var list = _vw002.GetMany(x => true);
            return list;
        }

        public VW001_RELATORIO_QTD_EMPREGADOS_CN_GI RelatorioQtdEmpregados()
        {
            var item = _vw001.GetOne(x => true);
            return item;
        }

        public IEnumerable<VW008_PRESTADORES_VITEC> BuscarPrestador(string pesquisa)
        {

            var lista = _vw008.GetMany(x => x.MATRICULA.ToLower() == pesquisa.ToLower()
            || x.CPF.Replace(".", "").Replace("-", "").ToLower() == pesquisa.Replace(".", "").Replace("-", "").ToLower()
            || x.RG.Replace(".", "").Replace("-", "").ToLower() == pesquisa.Replace(".", "").Replace("-", "").ToLower()
            || x.NOME.ToLower().Contains(pesquisa.ToLower()));

            return lista;
        }

        public IEnumerable<VW014_LISTA_PRESTADOR_SIGOC> BuscarPrestadorSIGOC(string pesquisa)
        {

            var lista = _vw014.GetMany(x => x.MATRICULA.ToLower() == pesquisa.ToLower()
            || x.CPF.Replace(".", "").Replace("-", "").ToLower() == pesquisa.Replace(".", "").Replace("-", "").ToLower()
            || x.RG.Replace(".", "").Replace("-", "").ToLower() == pesquisa.Replace(".", "").Replace("-", "").ToLower()
            || x.NOME.ToLower().Contains(pesquisa.ToLower()));

            return lista;
        }

        public IEnumerable<T071_CATALOGO_SERVICO> BuscarCatalogo(string catalogo)
        {
            var lista = _t071.GetMany(x => true);

            return lista;
        }

    }
}
