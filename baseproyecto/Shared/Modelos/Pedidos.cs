using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseproyecto.Shared.Modelos
{
    public class Pedidos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "debe escribir el nombre")]
        [StringLength(10)]
        public string? Nombrepedido { get; set; }
        [Required(ErrorMessage = "debe escribir la cantidad")]
        [StringLength(100)]
        public int Cantidapedido { get; set; }
        [Required(ErrorMessage = "debe escribir la fecha de pedido")]
        public DateTime Fechapedido { get; set; }
    }
}
