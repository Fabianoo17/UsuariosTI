using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T003_PERFIL_USUARIO : Entity
    {
        [Key]
        public int T003_ID_PERFIL_USUARIO { get; set; }
        public int? T003_FK_PERFIL { get; set; }
        public string T003_MAT_USUARIO { get; set; }
        public bool? T003_ATIVO { get; set; }
    }
}
