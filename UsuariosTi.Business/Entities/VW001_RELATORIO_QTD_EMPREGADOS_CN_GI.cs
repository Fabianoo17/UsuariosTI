using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsuariosTi.Business.Entities
{
    public class VW001_RELATORIO_QTD_EMPREGADOS_CN_GI : Entity
    {
        [Key]
        public int ID { get; set; }
        public int QTD_EMPREGADOS { get; set; }
        public int QTD_GERENCIA_FILIAIS { get; set; }
        public int QTD_CENTRALIZADORAS { get; set; }
    }
}
