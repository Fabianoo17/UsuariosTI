using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T039_DESTAQUE : Entity
    {
        [Key]
        public int T039_DESTAQUE_ID { get; set; }
        public string T039_TITULO { get; set; }
        public string T039_DESCRICAO { get; set; }
        public string T039_LINK { get; set; }
        public byte[] T039_IMAGEM { get; set; }
        public string T039_NOME_IMAGEM { get; set; }
        public DateTime? T039_DT_INICIO { get; set; }
        public DateTime? T039_DT_FIM { get; set; }
        public string T039_EMAILS { get; set; }
        public bool? T039_FLAG_EMAIL { get; set; }

        [NotMapped]
        public IFormFile anexo { get; set; }
    }
}
