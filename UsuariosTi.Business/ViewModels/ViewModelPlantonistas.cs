using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UsuariosTi.Business.Entities;

namespace UsuariosTi.Business.ViewModels
{
    public class ViewModelPlantonistas
    {
        public ViewModelPlantonistas()
        {
            Plantonistas = new List<VW007_CONSOLIDADO_PLANTONISTAS>();
            ListaTelefones = new List<T061_TELEFONE_MODULO_PLANTONISTA>();
            ListaPlantonistasCoordenacao = new List<VW011_LISTA_COORDENACAO_PLANTONISTA>();

            Meses = new List<ViewModelMeses>() {
                new ViewModelMeses{ID = 1,Mes = "Janeiro"},
                new ViewModelMeses{ID = 2,Mes = "Fevereiro"},
                new ViewModelMeses{ID = 3,Mes = "Março"},
                new ViewModelMeses{ID = 4,Mes = "Abril"},
                new ViewModelMeses{ID = 5,Mes = "Maio"},
                new ViewModelMeses{ID = 6,Mes = "Junho"},
                new ViewModelMeses{ID = 7,Mes = "Julho"},
                new ViewModelMeses{ID = 8,Mes = "Agosto"},
                new ViewModelMeses{ID = 9,Mes = "Setembro"},
                new ViewModelMeses{ID = 10,Mes = "Outubro"},
                new ViewModelMeses{ID = 11,Mes = "Novembro"},
                new ViewModelMeses{ID = 12,Mes = "Dezembro"},
            };
        }


        //public IEnumerable<VW011_LISTA_COORDENACAO_PLANTONISTA> Coordenacao { get; set; }

        public IEnumerable<VW007_CONSOLIDADO_PLANTONISTAS> Plantonistas { get; set; }
        public IEnumerable<T061_TELEFONE_MODULO_PLANTONISTA> ListaTelefones { get; set; }
        public IEnumerable<T056_PLANTONISTAS> ListaPlantonistas { get; set; }
        public IEnumerable<VW011_LISTA_COORDENACAO_PLANTONISTA> ListaPlantonistasCoordenacao { get; set; }
        private string matricula = "";

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Matrícula")]

        public string Matricula
        {
            get { return matricula.ToUpper(); }
            set { matricula = value; }
        }
        public IEnumerable<ViewModelMeses> Meses { get; set; }
        public bool IS_ATIVO { get; set; }


        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public int? Centralizadora { get; set; }
        public int? CO_COORDENACAO_PLANTONISTA { get; set; }
        public string TEL_PESSOAL { get; set; }
        public int? coordenacaoUser { get; set; }
        public bool validaCoordenacao(int coordenacao)
        {
            if (coordenacao == null) return false;
            if (coordenacao == coordenacaoUser) return true;

            return false;

        }


    }
}
