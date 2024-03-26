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
        #region Instance Fields
        private Pizza _pizza;
        private int _totalPrice;
        private int _delivery = 40;
        #endregion

        #region Contruktor + PizzaList
        public MenuCatalog()
        {
            _pizza = Pizza;
            _totalPrice += _delivery;
        }
        List<Pizza> MenuCatalogList = new List<Pizza>()
            {
                new Pizza("Margarita", 100),
                new Pizza("Meatzza", 100),
                new Pizza("Mikispecial", 100),
                //New pizza to list
                new Pizza("Alot of alot", 100)
            };
        #endregion

        #region Properties
        public List<Pizza> MenuCatalogList1 { get => MenuCatalogList; set => MenuCatalogList = value; }
        public Pizza Pizza { get => _pizza; set => _pizza = value; }
        public int TotalPrice { get => _totalPrice; set => _totalPrice = value; }
        #endregion

        #region Method
        public void PrintMenu()
        {
            Console.WriteLine($"Pizza Menu:");
            foreach (Pizza pizza in MenuCatalogList)
            {
                Console.WriteLine($"{pizza}");
            }
            Console.WriteLine();
        }
        public void NewPizza(string name, int price)
        {
            Pizza _pizza = new Pizza(name, price);
            MenuCatalogList.Add(_pizza);
        }
        public Pizza GetPizza(string searchWord)
        {
            foreach (Pizza pizza in MenuCatalogList)
            {
                if (pizza.PizzaName.Equals(searchWord, StringComparison.OrdinalIgnoreCase))
                {
                    return pizza;
                }
            }
            throw new PizzaNotFoundExcep($"Pizza '{searchWord}' not found.");
        }
        public void UpdatePizza(int newPrice, string name)
        {
            for (int i = 0; i < MenuCatalogList.Count; i++)
            {
                if (string.Equals(MenuCatalogList[i].PizzaName, name, StringComparison.OrdinalIgnoreCase))
                {
                    MenuCatalogList[i].Price = newPrice;
                }
            }
        }
        public void DeletePizza(Pizza pizza)
        {
            MenuCatalogList1.Remove(pizza);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Pizza pizza in MenuCatalogList1)
            {
                sb.AppendLine(pizza.ToString());
            }
            return sb.ToString();
        }
        #endregion
    }
}
