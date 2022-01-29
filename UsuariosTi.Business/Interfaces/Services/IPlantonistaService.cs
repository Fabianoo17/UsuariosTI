using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface IPlantonistaService
    {
        IEnumerable<VW007_CONSOLIDADO_PLANTONISTAS> Plantonistas(int? ano, int? mes, int? centralizadora);
        IEnumerable<T054_DIA_PLANTONISTA> DiasPlantonistas(int ano, int mes, int centralizadora);
        IEnumerable<T056_PLANTONISTAS> ListaPlantonistas(int? centralizadora);
        IEnumerable<VW011_LISTA_COORDENACAO_PLANTONISTA> ListaPlantonistasCoordenacao(int? CO_COORDENACAO_PLANTONISTA);
        IEnumerable<T059_CENTRALIZADORAS> ListaCentralizadoras();
        void AtualizarPlantonista(T056_PLANTONISTAS plantonista);
        bool AdicionarPlantonista(T056_PLANTONISTAS plantonista);
        bool AdicionarDiaPlantonista(T054_DIA_PLANTONISTA dia);
        bool ExcluirDiaPlantonista(int dia);
        bool ExcluirPlantonista(int id);
        bool AdicionarAtualizarEscalar(T057_ESCALA_PLANTONISTA model);
        IEnumerable<VW000_USUARIOS> PesquisarUsuarios(string nomeOuMatricula);
        IEnumerable<T061_TELEFONE_MODULO_PLANTONISTA> ListaTelefones(int? centralizadora);
        int? CoordenacaoUser();
        
        IEnumerable<T055_COORDENACAO_PLANTONISTA> PesquisarCoordenacao();
        IEnumerable<VW011_LISTA_COORDENACAO_PLANTONISTA> ListaPlantonistasCoordenacaoPorCentralizadora(int centralizadora);
        //IEnumerable<VW011_LISTA_COORDENACAO_PLANTONISTA> Coordenacao();

    }
}
