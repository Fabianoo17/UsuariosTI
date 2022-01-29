using System.ComponentModel.DataAnnotations;

namespace UsuariosTi.Business.Entities
{
    public class T029_QUEM_SOMOS : Entity
    {
        [Key]
        public int T029_ID_QUEM_SOMOS { get; set; }

        public string T029_NOME_COORDENACAO { get; set; }

        public string T029_MISSAO { get; set; }

        public int? T029_ID_COORD_RH { get; set; }

    }
}
