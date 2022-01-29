using Microsoft.AspNetCore.Http;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using System.Collections.Generic;
using System.IO;
using UsuariosTi.Business.ViewModels;
using System;
using System.Linq;
using UsuariosTi.Business.Enum;

namespace UsuariosTi.Business.Services
{
    public class ReportagensTiService : IReportagensTiService
    {
        private readonly IT002_PERFILRepository _t002;
        private readonly IT003_PERFIL_USUARIORepository _t003;
        private readonly IT039_DESTAQUERepository _t039;
        private readonly IT065_DICAS_TIRepository _t065;
        private readonly IT066_INTERACOESRepository _t066;
        private readonly IT067_COMENTARIOSRepository _t067;
        private readonly IT081_COMENTARIOSRepository _t081;
        private readonly IVW000_USUARIORepository _vw000;
        private readonly IVW004_LISTA_USUARIO_ACESSORepository _vw004;
        private readonly IVW012_LISTA_DICASTIRepository _vw012;
        private readonly IVW013_LISTA_COMENTARIOSRepository _vw013;

        public ReportagensTiService(IT002_PERFILRepository t002,
            IT003_PERFIL_USUARIORepository t003,
            IT039_DESTAQUERepository t039,
            IT065_DICAS_TIRepository t065,
            IT066_INTERACOESRepository t066,
            IT067_COMENTARIOSRepository t067,
            IVW000_USUARIORepository vw000,
            IVW004_LISTA_USUARIO_ACESSORepository vw004,
            IVW012_LISTA_DICASTIRepository vw012,
            IT081_COMENTARIOSRepository t081,
            IVW013_LISTA_COMENTARIOSRepository vw013)
        {
            _t002 = t002;
            _t003 = t003;
            _t039 = t039;
            _t065 = t065;
            _t066 = t066;
            _t067 = t067;
            _t081 = t081;

            _vw000 = vw000;
            _vw004 = vw004;
            _vw012 = vw012;
            _vw013 = vw013;
        }

        public void AlteraStatus(int idNotica, string matricula, bool status)
        {
            var interacao = _t066.GetOne(x => x.T066_USER_INTERACAO == matricula && x.T065_ID == idNotica);

            if (interacao == null)
            {
                interacao.T066_FLAG_CURTIR = status;
                _t066.Update(interacao);
            }

            else
            {
                interacao.T066_FLAG_CURTIR = status;
                _t066.Update(interacao);

            }
           

        }

        public int countCurtir(int idNotica, string matricula, bool status)
        {
            return _t066.GetMany(x => x.T065_ID == idNotica && x.T066_FLAG_CURTIR == status).Count();
        }

        public void CadastraVisualizacao(string matricula, int idDicasTi)
        {
            var interacao = _t066.GetOne(x => x.T066_USER_INTERACAO == matricula && x.T065_ID == idDicasTi);
            if (interacao == null)
            {
                var validaInteracao = new T066_INTERACOES()
                {
                    T065_ID = idDicasTi,
                    T066_USER_INTERACAO = matricula,
                    T066_FLAG_ATIVO = true
                };
                _t066.Insert(validaInteracao);
            }

        }

        public void CadastraComentario(int idDicasTi, string matricula, string comentario)
        {
            var comentarios = new T067_COMENTARIOS()
            {
                T065_ID = idDicasTi,
                T067_COMENTARIO = comentario,
                T067_DT_CADASTRO = DateTime.Now,
                T067_USER_INTERACAO = matricula,
                T067_FLAG_ATIVO = true
            };

            _t067.Insert(comentarios);
        }

        public ViewModelReportagensTi ListarNoticiasDestaque(string textoFiltro)
        {
            ViewModelReportagensTi viewModel = new ViewModelReportagensTi();

            viewModel.T066_INTERACOESs = _t066.GetMany(x => true);
            var listavw12 = String.IsNullOrEmpty(textoFiltro) ? _vw012.GetMany(x => true).OrderByDescending(o => o.T065_DT_CADASTRO) :
                                                                   _vw012.GetMany(x => x.T065_TITULO.ToUpper().Contains(textoFiltro.ToUpper())).OrderByDescending(o => o.T065_DT_CADASTRO);
            viewModel.VW012_LISTA_DICASTIs = TratarItensVW012(listavw12.ToList());

            return viewModel;
        }

        public ViewModelReportagensTi RetornaReportagemPorId(int idReportagem, string matricula)
        {
            ViewModelReportagensTi viewModel = new ViewModelReportagensTi();

            viewModel.VW012_LISTA_DICASTI = _vw012.GetOne(x => x.T065_ID == idReportagem);
            viewModel.VW012_LISTA_DICASTI.QTD_VISUALIZACAO = ListarComentariosPorTipo(viewModel.VW012_LISTA_DICASTI.T065_ID, (int)EnumTipoComentario.DicasTi).Count();
            viewModel.VW013_LISTA_COMENTARIOSs = _vw013.GetMany(x => x.T065_ID == idReportagem);
            var listavw12 = _vw012.GetMany(x => true);
            viewModel.VW012_LISTA_DICASTIs = TratarItensVW012(listavw12.ToList());
            viewModel.T066_INTERACOES = _t066.GetOne(x => x.T065_ID == idReportagem && x.T066_USER_INTERACAO == matricula);
            return viewModel;
        }

        public VW012_LISTA_DICASTI DetalhaCarregaReportagem(int idReportagem)
        {
            var item = _vw012.GetOne(x => x.T065_ID == idReportagem);
            item.QTD_COMENTARIOS = ListarComentariosPorTipo(item.T065_ID, (int)EnumTipoComentario.DicasTi).Count();
            item.QTD_VISUALIZACAO = _t066.GetMany(x => x.T065_ID == idReportagem).Count();

            return item;
        }

        public string TituloDicas(int Id)
        {
            var titulo = _t065.GetOne(x => x.T065_ID == Id);
            return titulo.T065_TITULO;
        }

        public int? ContaComentarios(int idReportagem)
        {
            var count = _t081.GetMany(x => x.ID_Tipo_Indice == 1 && x.ID_Dica_Acoes == idReportagem).Count();
            
            return count;
        }

        public IEnumerable<VW012_LISTA_DICASTI> RetornarTodasDicas()
        {
            var lista = _vw012.GetMany(x => true);
            return TratarItensVW012(lista.ToList());
        }

        public int? ContadorLikeDica(int id)
        {
            var dados = _t065.GetOne(x => x.T065_ID == id);
            dados.T065_POSITIVO++;

            _t065.Update(dados);

            return dados.T065_POSITIVO;
        }
        public int? ContadorDeslikeDica(int id)
        {
            var dados = _t065.GetOne(x => x.T065_ID == id);
            dados.T065_NEGATIVO++;

            _t065.Update(dados);

            return dados.T065_NEGATIVO;
        }

        public IEnumerable<T081_COMENTARIOS> ListarComentariosPorTipo(int id, int tipo)
        {
            return _t081.GetMany(x => x.ID_Tipo_Indice == tipo && x.ID_Dica_Acoes == id).OrderByDescending(o => o.ID);
        }
     
        private IEnumerable<VW012_LISTA_DICASTI> TratarItensVW012(List<VW012_LISTA_DICASTI> lista)
        {
            var listaTratada = new List<VW012_LISTA_DICASTI>();

            foreach(var item in lista)
            {
                var itemTratado = new VW012_LISTA_DICASTI();

                itemTratado.QTD_CURTIR = item.QTD_CURTIR;
                itemTratado.QTD_COMENTARIOS = ListarComentariosPorTipo(item.T065_ID,(int)EnumTipoComentario.DicasTi).Count();
                itemTratado.QTD_DESCURTIR = item.QTD_DESCURTIR;
                itemTratado.QTD_VISUALIZACAO = item.QTD_VISUALIZACAO;
                itemTratado.T065_BREVE_DESCRICAO = item.T065_BREVE_DESCRICAO;
                itemTratado.T065_DT_CADASTRO = item.T065_DT_CADASTRO;
                itemTratado.T065_ID = item.T065_ID;
                itemTratado.T065_IMAG = item.T065_IMAG;
                itemTratado.T065_NEGATIVO = item.T065_NEGATIVO;
                itemTratado.T065_POSITIVO = item.T065_POSITIVO;
                itemTratado.T065_TEXTO = item.T065_TEXTO;
                itemTratado.T065_TITULO = item.T065_TITULO;
                itemTratado.T065_USER_CADASTRO = item.T065_USER_CADASTRO;
                itemTratado.T065_VISUALIZACAO = item.T065_VISUALIZACAO;
                itemTratado.T065_ANEXO = item.T065_ANEXO;
                itemTratado.T065_NO_ANEXO = item.T065_NO_ANEXO;

                listaTratada.Add(itemTratado);
            }

            return listaTratada;
        }




    }
}
