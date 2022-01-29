using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.ViewModels.Home.Comentarios;

namespace UsuariosTi.Business.ViewModels.Home.UltimasAcoes
{
    public class T079_ULTIMAS_ACOESViewModel
    {

        public T079_ULTIMAS_ACOESViewModel()
        {
            ListarComentarios = new List<T081_COMENTARIOS>();
        }

        public int ID { get; set; }

        public string Titulo { get; set; }

        public DateTime? Data { get; set; }

        public string Caminho { get; set; }

        public bool? Video { get; set; }

        public string Resumo { get; set; }

        public string Texto { get; set; }

        public int? Positivo { get; set; }

        public int? Negativo { get; set; }

        public int? Visualizacao { get; set; }

        public int? QuantComentario { get; set; }

        public string No_Imagem { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public IFormFile File { get; set; }

        public IEnumerable<T081_COMENTARIOS> ListarComentarios;
    }
}
