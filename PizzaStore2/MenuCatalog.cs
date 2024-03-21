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
        private Pizza _pizza;
        private int _totalPrice;
        public MenuCatalog()
        {
            _pizza = Pizza;
        }
        List<Pizza> MenuCatalogList = new List<Pizza>()
            {
                new Pizza("Margarita", 100),
                new Pizza("Meatzza", 100),
                new Pizza("Mikispecial", 100)
            };

        public List<Pizza> MenuCatalogList1 { get => MenuCatalogList; set => MenuCatalogList = value; }
        public Pizza Pizza { get => _pizza; set => _pizza = value; }
        public int TotalPrice { get => _totalPrice; set => _totalPrice = value; }

        public void PrintMenu()
        {
            Console.WriteLine("Pizza Menu:");
            foreach (Pizza pizza in MenuCatalogList)
            {
                Console.WriteLine($"{pizza}");
            }
            Console.WriteLine();
        }

    }
}
