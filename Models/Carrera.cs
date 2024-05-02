using System.ComponentModel.DataAnnotations;

namespace NNegrete.Models
{
    public class Carrera
    {
        public String Nombre_carrera { get; set; }
        public String Campus { get; set; }
        public int Numero_semestres { get; set; }
        [Key]
        public int IdCarrera { get; set; }
    }
}
