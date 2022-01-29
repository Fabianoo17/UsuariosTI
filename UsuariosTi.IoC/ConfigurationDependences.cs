using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UsuariosTi.Business.Extensions;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.Services;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;

namespace UsuariosTi.IoC
{
    public static class ConfigurationDependences
    {
        public static IServiceCollection AddDependences(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("UsuariosTiConnection");
            services.AddDbContext<ServicoRegionaisContext>(opt => opt.UseSqlServer(connection));

            services.AddScoped<IT002_PERFILRepository, T002_PERFILRepository>();
            services.AddScoped<IT003_PERFIL_USUARIORepository, T003_PERFIL_USUARIORepository>();
            services.AddScoped<IT029_QUEM_SOMOSRepository, T029_QUEM_SOMOSRepository>();
            services.AddScoped<IT039_DESTAQUERepository, T039_DESTAQUERepository>();
            services.AddScoped<IT047_FERRAMENTARepository, T047_FERRAMENTARepository>();
            services.AddScoped<IT052_PRESTADORES_SCPRepository, T052_PRESTADORES_SCPRepository>();
            services.AddScoped<IT054_DIA_PLANTONISTARepository, T054_DIA_PLANTONISTARepository>();
            services.AddScoped<IT055_COORDENACAO_PLANTONISTARepository, T055_COORDENACAO_PLANTONISTARepository>();
            services.AddScoped<IT056_PLANTONISTASRepository, T056_PLANTONISTASRepository>();
            services.AddScoped<IT057_ESCALA_PLANTONISTARepository, T057_ESCALA_PLANTONISTARepository>();
            services.AddScoped<IT059_CENTRALIZADORASRepository, T059_CENTRALIZADORASRepository>();
            services.AddScoped<IT061_TELEFONE_MODULO_PLANTONISTARepository, T061_TELEFONE_MODULO_PLANTONISTARepository>();
            services.AddScoped<IT065_DICAS_TIRepository, T065_DICAS_TIRepository>();
            services.AddScoped<IT066_INTERACOESRepository, T066_INTERACOESRepository>();
            services.AddScoped<IT067_COMENTARIOSRepository, T067_COMENTARIOSRepository>();
            services.AddScoped<IT068_ABRANGENCIARepository, T068_ABRANGENCIARepository>();
            services.AddScoped<IT071_CATALOGO_SERVICORepository, T071_CATALOGO_SERVICORepository>();
            services.AddScoped<IT072_PRESTADOR_SIGOCRepository, T072_PRESTADOR_SIGOCRepository>();
            services.AddScoped<IT073_CARROSSELRepository, T073_CARROSSELRepository>();
            services.AddScoped<IT074_ACESSO_RAPIDO_SITERepository, T074_ACESSO_RAPIDO_SITERepository>();
            services.AddScoped<IT075_QUEM_SOMOSRepository, T075_QUEM_SOMOSRepository>();
            services.AddScoped<IT076_NOSSO_TIMERepository, T076_NOSSO_TIMERepository>();
            services.AddScoped<IT077_UNIDADES_VINCULORepository, T077_UNIDADES_VINCULORepository>();
            services.AddScoped<IT078_CIAUS_TEXTORepository, T078_CIAUS_TEXTORepository>();
            services.AddScoped<IT079_ULTIMAS_ACOESRepository, T079_ULTIMAS_ACOESRepository>();
            services.AddScoped<IT080_TIPO_INDICERepository, T080_TIPO_INDICERepository>();
            services.AddScoped<IT081_COMENTARIOSRepository, T081_COMENTARIOSRepository>();
            services.AddScoped<IT082_INTERACOES_ULTIMAS_ACOESRepository, T082_INTERACOES_ULTIMAS_ACOESRepository>();


            services.AddScoped<IVW000_USUARIORepository, VW000_USUARIOSRepository>();
            services.AddScoped<IVW001_RELATORIO_QTD_EMPREGADOS_CN_GIRepository, VW001_RELATORIO_QTD_EMPREGADOS_CN_GIRepository>();
            services.AddScoped<IVW002_PERCENTUAL_PROJETOS_ANORepository, VW002_PERCENTUAL_PROJETOS_ANORepository>();
            services.AddScoped<IVW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECRepository, VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECRepository>();
            services.AddScoped<IVW004_LISTA_USUARIO_ACESSORepository, VW004_LISTA_USUARIO_ACESSORepository>();
            services.AddScoped<IVW005_RETRATO_TI_SERVICOS_REGIONAISRepository, VW005_RETRATO_TI_SERVICOS_REGIONAISRepository>();
            services.AddScoped<IVW007_CONSOLIDADO_PLANTONISTASRepository, VW007_CONSOLIDADO_PLANTONISTASRepository>();
            services.AddScoped<IVW011_LISTA_COORDENACAO_PLANTONISTASRepository, VW011_LISTA_COORDENACAO_PLANTONISTARepository>();
            services.AddScoped<IVW012_LISTA_DICASTIRepository, VW012_LISTA_DICASTIRepository>();
            services.AddScoped<IVW013_LISTA_COMENTARIOSRepository, VW013_LISTA_COMENTARIOSRepository>();
            services.AddScoped<IVW008_PRESTADORES_VITECRepository, VW008_PRESTADORES_VITECRepository>();
            services.AddScoped<IVW014_LISTA_PRESTADOR_SIGOCRepository, VW014_LISTA_PRESTADOR_SIGOCRepository>();
            services.AddScoped<IVW016_RELATORIO_PRESTADORESRepository, VW016_RELATORIO_PRESTADORESRepository>();

            services.AddScoped<IUser, AspNetUser>();

            services.AddScoped<IAcessoService, AcessoService>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IHistoricoService, HistoricoService>();
            services.AddScoped<IComunicacaoService, ComunicacaoService>();
            services.AddScoped<IPlantonistaService, PlantonistaService>();
            services.AddScoped<IReportagensTiService, ReportagensTiService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IConsultarPrestadoresService, ConsultarPrestadoresService>();
            services.AddScoped<ICatalogoService, CatalogoService>();
            services.AddScoped<IConsultarPrestadoresSIGOCService, ConsultarPrestadoresSIGOCService>();


            return services;
        }
    }
}
