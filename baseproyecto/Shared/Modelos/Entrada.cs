using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseproyecto.Shared.Modelos
{
    public class Entrada
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "debe escribir el nombre")]
        [StringLength(10)]
        public string? Nombreentrada { get; set; }
        [Required(ErrorMessage = "debe escribir la cantidad")]
        [StringLength(100)]
        public int Cantidadentrada { get; set; }
        [Required(ErrorMessage = "debe escribir la fecha de entrada")]
        public DateTime Fechaentrada { get; set; }
    }
}
