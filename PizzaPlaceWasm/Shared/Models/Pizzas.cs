using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlaceWasm.Shared.Models
{
    public class Pizzas
    {
        public Pizzas(int Id, string Nombre, decimal Precio, Picante Picante)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Picante = Picante;
        }
        public int Id { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public Picante Picante { get; }
    }
}
