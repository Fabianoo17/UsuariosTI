using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW004_LISTA_USUARIO_ACESSO : Entity
    {
        [Key]
        public int? T003_ID_PERFIL_USUARIO { get; set; }
        public string T003_MAT_USUARIO { get; set; }
        public string USUARIO { get; set; }
        public string T002_DESC_PERFIL { get; set; }
        public int? T002_ID_PERFIL { get; set; }
    }
}
