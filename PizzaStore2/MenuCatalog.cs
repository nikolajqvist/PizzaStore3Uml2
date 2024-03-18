using PizzaStore2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore3
{
    public class MenuCatalog
    {
            List<Pizza> MenuList = new List<Pizza>()
            {
                new Pizza("Margarita", 100),
                new Pizza("Meatzza", 100),
                new Pizza("Mikispecial", 100)
            };

        public List<Pizza> MenuList1 { get => MenuList; set => MenuList = value; }
        public void PrintMenu()
        {
            Console.WriteLine("Pizza Menu:");
            foreach (Pizza pizza in MenuList)
            {
                Console.WriteLine($"{pizza}");
            }
            Console.WriteLine();
        }
    }
}
