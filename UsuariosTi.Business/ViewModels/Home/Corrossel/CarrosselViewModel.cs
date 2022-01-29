using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;

namespace UsuariosTi.Business.ViewModels.Home.Corrossel
{
    public class CarrosselViewModel
    {

        public int NU_CARROSSEL { get; set; }

        public string NO_IMAGEM { get; set; }

        public int? NU_ORDENACAO { get; set; }

        public bool? IC_ATIVO { get; set; }
        public string TEXTO { get; set; }

        public byte[] IMAGEM { get; set; }

        public bool? BOTAO { get; set; }
        public string TEXTO_BOTAO { get; set; }
        public string TIPO_BOTAO { get; set; }
        public string LINK { get; set; }

        public IFormFile File { get; set; }

        public IEnumerable <T073_CARROSSEL> ListaT073_CARROSSEL { get; set; }
      
    }
}
