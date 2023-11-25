using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseproyecto.Shared.Modelos
{
    public class Alimentos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "debe escribir el nombre")]
        [StringLength(10)]
        public string? Nombredespensa { get; set; }
        [Required(ErrorMessage = "debe escribir la cantidad")]
        [StringLength(100)]
        public int Cantidaddespensa { get; set; }
        [Required(ErrorMessage = "debe escribir la fecha de caducidad")]
        public DateTime Fechacaducidad { get; set; }
    }
}
