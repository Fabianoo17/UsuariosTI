using UsuariosTi.Business.Entities;
using UsuariosTi.Business.ViewModels;
using System.Collections.Generic;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface IReportagensTiService
    {
        ViewModelReportagensTi ListarNoticiasDestaque(string textoFiltro);
        ViewModelReportagensTi RetornaReportagemPorId(int idReportagem, string matricula);
        VW012_LISTA_DICASTI DetalhaCarregaReportagem(int idReportagem);
        void CadastraVisualizacao(string matricula, int idDicasTi);
        void AlteraStatus(int idNotica, string matricula, bool status);
        int countCurtir(int idNotica, string matricula, bool status);
        void CadastraComentario(int idDicasTi, string matricula, string comentario);
        IEnumerable<VW012_LISTA_DICASTI> RetornarTodasDicas();
        int? ContadorLikeDica(int id);
        int? ContadorDeslikeDica(int id);
        int? ContaComentarios(int idReportagem);
        string TituloDicas(int Id);


    }
}
