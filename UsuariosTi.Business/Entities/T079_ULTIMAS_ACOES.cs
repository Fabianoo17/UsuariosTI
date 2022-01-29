using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T079_ULTIMAS_ACOES : Entity
    {
        [Key]
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

        public string No_Imagem { get; set; }

        public string Matricula { get; set; }
        public string Nome { get; set; }

    }
}
