using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T080_TIPO_INDICE :Entity
    {
        [Key]
        public int ID { get; set; }

        public int? Tipo { get; set; }

        public string Descricao { get; set; }
    }
}
