﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migraciones.Shared.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }

        public int ClienteId { get; set; }

        public int PrioridadId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Asunto { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Descripción { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(30, ErrorMessage = "No puede exceder los 30 Caracteres")]
        public string? SolicitadoPor { get; set; }
    }
}
