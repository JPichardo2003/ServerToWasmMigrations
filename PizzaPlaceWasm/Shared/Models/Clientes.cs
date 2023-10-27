using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlaceWasm.Shared.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor proporcione su nombre")]
        [StringLength(30, ErrorMessage = "No puedes exceder los 30 caracteres")]
        public string Nombre { get; set; } = default!;

        [Required(ErrorMessage = "Por Favor proporcione su Calle con el Numero de Casa")]
        public string Calle { get; set; } = default!;

        [Required(ErrorMessage = "Por Favor Proporcione una ciudad")]
        public string Ciudad { get; set; } = default!;
    }
}
