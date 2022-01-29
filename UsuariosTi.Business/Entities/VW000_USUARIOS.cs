using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Corretora.Business.Entities
{
    [Table("VW000_USUARIOS")]
    public class VW000_USUARIOS : Entity
    {
        [Key]
        public string MATRICULA { get; set; }
        public string NOME { get; set; }
        public int? NU_UNID_ADM { get; set; }
        public string SG_UNID_ADM { get; set; }
    }
}