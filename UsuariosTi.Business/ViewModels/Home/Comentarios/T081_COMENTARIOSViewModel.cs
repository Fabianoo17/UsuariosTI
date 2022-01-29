using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Business.ViewModels.Home.Comentarios
{
    public class T081_COMENTARIOSViewModel
    {
        public int ID { get; set; }

        public int? ID_Tipo_Indice { get; set; }

        public int? ID_Dica_Acoes { get; set; }

        public string Comentarios { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
    }
}
