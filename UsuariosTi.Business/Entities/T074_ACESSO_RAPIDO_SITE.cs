using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T074_ACESSO_RAPIDO_SITE: Entity
    {
        [Key]
        public int T074_NU_ACESSO_RAPIDO { get; set; }

        public string T074_NO_BOTAO { get; set; }

        public string T074_LINK_BOTAO { get; set; }

        public int? T074_CO_COORDENACAO { get; set; }

        public int? T074_IC_ATIVO { get; set; }

    }
}
