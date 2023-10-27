using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlaceWasm.Shared.Models
{
    public class Estados
    {
        public Menu Menu { get; } = new Menu();
        public CestaCompras Cesta { get; } = new CestaCompras();
        public InterfazUsuarios Interfaz { get; set; } = new InterfazUsuarios();
        public decimal PrecioTotal => Cesta.Pedidos.Sum(Id => Menu.GetPizza(Id)!.Precio);
    }
}
