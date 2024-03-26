using PizzaStore3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class PizzaStore
    {
        public void MenuChoice()
        {          
            #region Menu & Customers
            MenuCatalog catalog = new MenuCatalog();
            catalog.PrintMenu();
            #endregion

            #region Newpizza 
            //costumers.UpdateCostumer("", "");
            Console.ReadKey(false);
            Console.Clear();
            catalog.NewPizza("Tytyty", 100);
            Console.WriteLine(catalog.ToString());
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Update Pizza
            catalog.UpdatePizza(65, "Margarita");
            catalog.PrintMenu();
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Order 1

            Order order = new Order(2);
            //costumers.AddCostumer(costumers.Costumerss1[0]);
            Console.WriteLine($"Jørgen\nHan bestiller {order.NumberOfPizzas} pizzaer.");
            order.AddPizzaToOrder(catalog.MenuCatalogList1[1]);
            order.AddPizzaToOrder(catalog.MenuCatalogList1[2]);
            order.AddPizzaToOrder(catalog.MenuCatalogList1[4]);
            order.OrderPriceTotal();
            Console.WriteLine(order.ToString());
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Order 2
            Order order2 = new Order(3);
            //costumers.AddCostumer(costumers.Costumerss1[1]);
            Console.WriteLine($"Ulrik\nHan bestiller {order2.NumberOfPizzas} pizzaer.");
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[1]);
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[2]);
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[3]);
            order2.OrderPriceTotal();
            Console.WriteLine(order2.ToString());
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Try and Catch Exception
            try
            {
                Pizza Pizza = catalog.GetPizza("Tytyty");
                Console.WriteLine("Found pizza: " + Pizza.PizzaName);
            }
            catch (PizzaNotFoundExcep ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
            #endregion


        }
    }
}
