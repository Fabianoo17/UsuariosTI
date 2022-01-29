using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T071_CATALOGO_SERVICO: Entity
    {
        [Key]
        public int T071_ID_CATALOGO_SERVICO { get; set; }
        public int T070_ID_GERENCIA { get; set; }
        public string T071_NO_COORDENACAO { get; set; }
        public string T071_NO_SERVICO { get; set; }
        public string T071_DESC_ORIENTACAO { get; set; }
        public string T071_DESC_SOLICITACAO { get; set; }
        public string T071_LINK { get; set; }
        public bool? T071_ATIVO { get; set; }

    }
}
