using System.ComponentModel.DataAnnotations;

namespace NNegrete.Models
{
    public class Estudiante
    {
        [Key]
        public int IdBanner { get; set; }
        public float Promedio { get; set; }
        [Required] 
        public String Nombre { get; set; }
        public Boolean Matriculado { get; set; }
         

    }
}
