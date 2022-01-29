using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;

namespace UsuariosTi.Business.Services
{
    public class PlantonistaService : IPlantonistaService
    {
        private readonly IVW007_CONSOLIDADO_PLANTONISTASRepository _vW007_Plantonistas;
        private readonly IT056_PLANTONISTASRepository _t056_PLANTONISTAS;
        private readonly IT054_DIA_PLANTONISTARepository _t054_DIAS_PLANTONISTAS;
        private readonly IT057_ESCALA_PLANTONISTARepository _t057_escala;
        private readonly IT059_CENTRALIZADORASRepository _t059_centralizadoras;
        private readonly IT061_TELEFONE_MODULO_PLANTONISTARepository _t061_telefone_modulo_plantonista;
        private readonly IVW000_USUARIORepository _vW000_Usuarios;
        private readonly IUser _user;
        private readonly IT055_COORDENACAO_PLANTONISTARepository _t055_COORDENACAO;
        private readonly IVW011_LISTA_COORDENACAO_PLANTONISTASRepository _vw011_lista_coordenacao_plantonistas;



        public PlantonistaService(IVW007_CONSOLIDADO_PLANTONISTASRepository vW007_Plantonistas,
                                  IT056_PLANTONISTASRepository t056_PLANTONISTAS,
                                  IT059_CENTRALIZADORASRepository t059_centralizadoras,
                                  IT057_ESCALA_PLANTONISTARepository t057_escala,
                                  IVW000_USUARIORepository vW000_Usuarios,
                                  IT061_TELEFONE_MODULO_PLANTONISTARepository t061_telefone_modulo_plantonista,
                                  IT055_COORDENACAO_PLANTONISTARepository t055_COORDENACAO,
                                  IVW011_LISTA_COORDENACAO_PLANTONISTASRepository vw011_lista_coordenacao_plantonistas,
                                  IT054_DIA_PLANTONISTARepository t054_DIAS_PLANTONISTAS,
                                  IUser user)
        {
            _vW007_Plantonistas = vW007_Plantonistas;
            _vW000_Usuarios = vW000_Usuarios;
            _t056_PLANTONISTAS = t056_PLANTONISTAS;
            _t057_escala = t057_escala;
            _t059_centralizadoras = t059_centralizadoras;
            _user = user;
            _t061_telefone_modulo_plantonista = t061_telefone_modulo_plantonista;
            _t055_COORDENACAO = t055_COORDENACAO;
            _vw011_lista_coordenacao_plantonistas = vw011_lista_coordenacao_plantonistas;
            _t054_DIAS_PLANTONISTAS = t054_DIAS_PLANTONISTAS;


        }

        public IEnumerable<VW007_CONSOLIDADO_PLANTONISTAS> Plantonistas(int? ano, int? mes, int? centralizadora)
        {
            var list = _vW007_Plantonistas.GetMany(x => Convert.ToDateTime(x.DIA).Year == ano && Convert.ToDateTime(x.DIA).Month == mes && x.CGC_CENTRALIZADORA == centralizadora);
            if (list.Any())
            {
                return list;
            }
            return new List<VW007_CONSOLIDADO_PLANTONISTAS>();
        }

        public IEnumerable<T056_PLANTONISTAS> ListaPlantonistas(int? centralizadora)
        {
            var list = _t056_PLANTONISTAS.GetMany(x => x.CGC_CENTRALIZADORA == centralizadora);
            if (list.Any())
            {
                return list;
            }
            return new List<T056_PLANTONISTAS>();
        }

        public IEnumerable<VW011_LISTA_COORDENACAO_PLANTONISTA> ListaPlantonistasCoordenacao(int? CO_COORDENACAO_PLANTONISTA)
        {
            var list = _vw011_lista_coordenacao_plantonistas.GetMany(x => true);
            if (list.Any())
            {
                return list;
            }
            return new List<VW011_LISTA_COORDENACAO_PLANTONISTA>();
        }

        public IEnumerable<VW011_LISTA_COORDENACAO_PLANTONISTA> ListaPlantonistasCoordenacaoPorCentralizadora(int centralizadora)
        {
            var list = _vw011_lista_coordenacao_plantonistas.GetMany(x => (x.CGC_CENTRALIZADORA == centralizadora));
            if (list.Any())
            {
                return list;
            }
            return new List<VW011_LISTA_COORDENACAO_PLANTONISTA>();
        }



        public void AtualizarPlantonista(T056_PLANTONISTAS plantonista)
        {
            var item = _t056_PLANTONISTAS.GetOne(x => x.CO_PLANTONISTA == plantonista.CO_PLANTONISTA);

            item.NOME_EXIBICAO = plantonista.NOME_EXIBICAO;
            item.IS_ATIVO = plantonista.IS_ATIVO;
            item.DT_CRIACAO = DateTime.Now;
            item.CRIADOR = _user.Matricula;
            _t056_PLANTONISTAS.Update(item);

        }




        public bool AdicionarAtualizarEscalar(T057_ESCALA_PLANTONISTA model)
        {

            var item = _t057_escala.GetOne(x => x.DIA == model.DIA && x.CO_COORDENACAO_PLANTONISTA == model.CO_COORDENACAO_PLANTONISTA);
            if (item != null)
            {
                item.CO_PLANTONISTA = model.CO_PLANTONISTA;
                item.MAT_ALTERACAO = _user.Matricula;
                item.DT_ALTERACAO = DateTime.Now;
                _t057_escala.Update(item);
                return true;
            }
            else
            {
                model.DT_ALTERACAO = DateTime.Now;
                model.MAT_ALTERACAO = _user.Matricula;
                _t057_escala.Insert(model);

                return true;
            }

            return false;

        }

        public IEnumerable<VW000_USUARIOS> PesquisarUsuarios(string nomeOuMatricula)
        {
            var model = _vW000_Usuarios.PesquisarUsuarios(nomeOuMatricula);

            return model.OrderBy(x => x.NOME);
        }

        public IEnumerable<T061_TELEFONE_MODULO_PLANTONISTA> ListaTelefones(int? centralizadora)
        {
            var lista = _t061_telefone_modulo_plantonista.GetMany(x => x.CGC_CENTRALIZADORA == centralizadora);

            return lista.ToList();
        }


        public IEnumerable<T059_CENTRALIZADORAS> ListaCentralizadoras()
        {
            var model = _t059_centralizadoras.GetMany(x => true);

            return model.OrderBy(x => x.SG_CENTRALIZADORA);
        }


        public bool AdicionarPlantonista(T056_PLANTONISTAS plantonista)
        {
            var usuario = _vW000_Usuarios.GetOne(x => x.MATRICULA.ToUpper() == plantonista.MAT.ToUpper());

            // var plantonista_telefone = _t056_PLANTONISTAS.GetOne(x => x.TEL_PESSOAL == plantonista.TEL_PESSOAL);
            //var plantonistaUser = PesquisarCoordenacao(usuario)
            var validaPlantonista = _t056_PLANTONISTAS.GetMany(x => x.MAT == plantonista.MAT && x.CGC_CENTRALIZADORA == plantonista.CGC_CENTRALIZADORA).Any();
            if (validaPlantonista)
            {
                return false;
            }

            plantonista.NOME_EXIBICAO = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(usuario.NOME.ToLower());
            plantonista.IS_ATIVO = true;
            plantonista.DT_CRIACAO = DateTime.Now;
            plantonista.CRIADOR = _user.Matricula;



            try
            {
                _t056_PLANTONISTAS.Insert(plantonista);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T055_COORDENACAO_PLANTONISTA> PesquisarCoordenacao()
        {
            var model = _t055_COORDENACAO.GetMany(x => true);
            return model.OrderBy(x => x.NOME);
        }

        public bool ExcluirPlantonista(int id)
        {
            try
            {
                _t056_PLANTONISTAS.Remove(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int? CoordenacaoUser()
        {
            int? user = _t056_PLANTONISTAS.GetOne(x => x.MAT.ToUpper() == _user.Matricula.ToUpper())?.CO_COORDENACAO;

            return user;
        }

        public IEnumerable<T054_DIA_PLANTONISTA> DiasPlantonistas(int ano, int mes, int centralizadora)
        {
            return _t054_DIAS_PLANTONISTAS.GetMany(x => Convert.ToDateTime(x.DIA).Year == ano && Convert.ToDateTime(x.DIA).Month == mes && x.UNIDADE == centralizadora.ToString());
        }

        public bool AdicionarDiaPlantonista(T054_DIA_PLANTONISTA dia)
        {
            dia.COMPETENCIA = dia.DIA?.ToString("MM/yyyy");
            try
            {
                _t054_DIAS_PLANTONISTAS.Insert(dia);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ExcluirDiaPlantonista(int dia)
        {
            try
            {
                _t054_DIAS_PLANTONISTAS.Remove(dia);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
