using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlaceWasm.Shared.Models
{
    public class Menu
    {
        public List<Pizzas> Pizzas { get; set; } = new List<Pizzas>();
        public void Add(Pizzas pizza) => Pizzas.Add(pizza);
        public Pizzas? GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
