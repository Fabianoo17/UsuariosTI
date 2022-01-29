using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T047_FERRAMENTA : Entity
    {
        [Key]
        public int T047_ID_FERRAMENTA { get; set; }
        public int T047_CO_CATEGORIA { get; set; }
        public string T047_NO_CATEGORIA { get; set; }
        public string T047_NOME { get; set; }
        public string T047_LINK { get; set; }
        public string T047_DESCRICAO { get; set; }
    }
}
