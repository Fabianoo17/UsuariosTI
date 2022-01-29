using System.ComponentModel.DataAnnotations;

namespace Corretora.Business.Entities
{
    public class T002_PERFIL : Entity
    {
        [Key]
        public int T002_ID_PERFIL { get; set; }
        public string T002_DESC_PERFIL { get; set; }
        public bool? T002_ATIVO { get; set; }
    }
}
