using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("IdCarrera")]
        public int IdCarrera { get; set; }
         
        public Carrera Carrera { get; set; }
    }
}
