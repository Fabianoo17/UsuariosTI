using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UsuariosTi.Business.Entities;
using System;
using System.IO;

namespace UsuariosTi.Data.Context
{
    public class ServicoRegionaisContext : DbContext
    {
        public ServicoRegionaisContext(DbContextOptions options): base(options)
        {

        }

        //TABELA 
        public DbSet<T002_PERFIL> T002_PERFIL { get; set; }
        public DbSet<T003_PERFIL_USUARIO> T003_PERFIL_USUARIO { get; set; }
        public DbSet<T029_QUEM_SOMOS> T029_QUEM_SOMOS { get; set; }

        public DbSet<T039_DESTAQUE> T039_DESTAQUE { get; set; }
        public DbSet<T047_FERRAMENTA> T047_FERRAMENTA { get; set; }
        public DbSet<T052_PRESTADORES_SCP> T052_PRESTADORES_SCP { get; set; }
        public DbSet<T054_DIA_PLANTONISTA> T054_DIA_PLANTONISTA { get; set; }
        public DbSet<T055_COORDENACAO_PLANTONISTA> T055_COORDENACAO_PLANTONISTA { get; set; }
        public DbSet<T056_PLANTONISTAS> T056_PLANTONISTAS { get; set; }
        public DbSet<T057_ESCALA_PLANTONISTA> T057_ESCALA_PLANTONISTA { get; set; }
        public DbSet<T059_CENTRALIZADORAS> T059_CENTRALIZADORAS { get; set; }
        public DbSet<T061_TELEFONE_MODULO_PLANTONISTA> T061_TELEFONE_MODULO_PLANTONISTA { get; set; }
        public DbSet<T065_DICAS_TI> T065_DICAS_TI { get; set; }
        public DbSet<T066_INTERACOES> T066_INTERACOES { get; set; }
        public DbSet<T067_COMENTARIOS> T067_COMENTARIOS { get; set; }
        public DbSet<T068_ABRANGENCIA> T068_ABRANGENCIA { get; set; }
        public DbSet<T071_CATALOGO_SERVICO> T071_CATALOGO_SERVICO { get; set; }
        public DbSet<T072_PRESTADOR_SIGOC> T072_PRESTADOR_SIGOC { get; set; }
        public DbSet<T073_CARROSSEL> T073_CARROSSEL { get; set; }
        public DbSet <T074_ACESSO_RAPIDO_SITE> T074_ACESSO_RAPIDO_SITE { get; set; }
        public DbSet<T075_QUEM_SOMOS> T075_QUEM_SOMOS { get; set; }

        public DbSet<T076_NOSSO_TIME> T076_NOSSO_TIME { get; set; }
        public DbSet<T077_UNIDADES_VINCULO> T077_UNIDADES_VINCULO { get; set; }
        public DbSet<T078_CIAUS_TEXTO> T078_CIAUS_TEXTO { get; set; }
        public DbSet<T079_ULTIMAS_ACOES> T079_ULTIMAS_ACOES { get; set; }
        public DbSet<T080_TIPO_INDICE> T080_TIPO_INDICE { get; set; }
        public DbSet<T081_COMENTARIOS> T081_COMENTARIOS { get; set; }
        public DbSet<T082_INTERACOES_ULTIMAS_ACOES> T082_INTERACOES_ULTIMAS_ACOES { get; set; }


        //VIEWS
        public DbSet<VW000_USUARIOS> VW000_USUARIOS { get; set; }
        public DbSet<VW001_RELATORIO_QTD_EMPREGADOS_CN_GI> VW001_RELATORIO_QTD_EMPREGADOS_CN_GI { get; set; }
        public DbSet<VW002_PERCENTUAL_PROJETOS_ANO> VW002_PERCENTUAL_PROJETOS_ANO { get; set; }
        public DbSet<VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETEC> VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETEC { get; set; }
        public DbSet<VW004_LISTA_USUARIO_ACESSO> VW004_LISTA_USUARIO_ACESSO { get; set; }
        public DbSet<VW005_RETRATO_TI_SERVICOS_REGIONAIS> VW005_RETRATO_TI_SERVICOS_REGIONAIS { get; set; }
        public DbSet<VW007_CONSOLIDADO_PLANTONISTAS> VW007_CONSOLIDADO_PLANTONISTAS { get; set; }
        public DbSet<VW012_LISTA_DICASTI> VW012_LISTA_DICASTI { get; set; }
        public DbSet<VW011_LISTA_COORDENACAO_PLANTONISTA> VW011_LISTA_COORDENACAO_PLANTONISTA { get; set; }
        public DbSet<VW013_LISTA_COMENTARIOS> VW013_LISTA_COMENTARIOS { get; set; }

        public DbSet<VW008_PRESTADORES_VITEC> VW008_PRESTADORES_VITEC { get; set; }
        public DbSet<VW014_LISTA_PRESTADOR_SIGOC> VW014_LISTA_PRESTADOR_SIGOC { get; set; }
        public DbSet<VW016_RELATORIO_PRESTADORES> VW016_RELATORIO_PRESTADORES { get; set; }
    }
}
