using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class T078_CIAUS_TEXTO : Entity
    {
        [Key]
        public int ID { get; set; }

        public string SG_FILIAL { get; set; }

        public string Texto { get; set; }
        public string Link { get; set; }
    }
}
