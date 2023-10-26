using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migraciones.Shared.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Descripcion { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "DiasCompromiso debe ser mayor que 0.")]
        public int DiasCompromiso { get; set; }

        [ForeignKey("PrioridadId")]
        public ICollection<Tickets> Tickets { get; set; } = new List<Tickets>();
    }
}
