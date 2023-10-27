using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlaceWasm.Shared.Models
{
    public class CestaCompras
    {
        public Clientes Cliente { get; set; } = new Clientes();
        public List<int> Pedidos { get; set; } = new List<int>();
        public bool Pago { get; set; }
        public void Add(int pizzaId) => Pedidos.Add(pizzaId);
        public void RemoveAt(int pos) => Pedidos.RemoveAt(pos);
    }
}
