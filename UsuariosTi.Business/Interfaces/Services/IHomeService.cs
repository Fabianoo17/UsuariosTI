using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.ViewModels.Home;
using UsuariosTi.Business.ViewModels.Home.Corrossel;
using UsuariosTi.Business.ViewModels.Home.DicasTi;
using UsuariosTi.Business.ViewModels.Home.UltimasAcoes;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface IHomeService
    {
        IndexViewModel PopularIndexModel(string pesquisa);
        List<T076_NOSSO_TIME> ListarNossoTime();
        T077_UNIDADES_VINCULO GetUnidadeVinculo(int cgc);
        T077_UNIDADES_VINCULO GetUnidade(int cgc);
        T078_CIAUS_TEXTO GetTexto(string filial);
        IEnumerable<T047_FERRAMENTA> ListarFerramentas(int id);
        IEnumerable<T079_ULTIMAS_ACOESViewModel> ListarUltimasAcoes(int quantidade);
        IEnumerable<T065_DICAS_TI> ListarDicasTI();
        IEnumerable<T073_CARROSSEL> ListarCarousel();
        int? ContadorLike(int id);
        int? ContadorDeslike(int id);
        T079_ULTIMAS_ACOES ContadorVisualizar(int id);
        IEnumerable<T081_COMENTARIOS> ListarComentarios(int id);
        IEnumerable<VW005_RETRATO_TI_SERVICOS_REGIONAIS> RelatorioUsuariosTi();
        IEnumerable<VW005_RETRATO_TI_SERVICOS_REGIONAIS> RelatorioUsuariosTiExcel();

        void SalvarComentario(T081_COMENTARIOS model);
        void SalvarComentarioDicaTi(T081_COMENTARIOS model);

        IEnumerable<T081_COMENTARIOS> ListarComentariosPorTipo(int id, int tipo);
        string DataAtualizacao();
        void SalvarUltimasAcoes(T079_ULTIMAS_ACOESViewModel Model);
        void UpdateUltimasAcoes(T079_ULTIMAS_ACOESViewModel Model);
        void DeleteUltimasAcoes(int id);
        T079_ULTIMAS_ACOES EditarUltimasAcoes(int id);

        void SalvarDicasTI(T065_DICAS_TIViewModel Model);
        void UpdateDicasTI(T065_DICAS_TIViewModel Model);
        void DeleteDicasTI(int id);
        T065_DICAS_TI EditarDicasTI(int id);

        void SalvarCarousel(CarrosselViewModel Model);
        void UpdateCarousel(CarrosselViewModel Model);
        void DeleteCarousel(int id);
        T073_CARROSSEL EditarCarousel(int id);
    }
}
