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
            #region Costumers
            CostumerCatalog costumers = new CostumerCatalog();
            Console.WriteLine("Costumer list:");
            costumers.CostumersInList();
            costumers.CreateCostumer("Jannik", 41);            
            costumers.UpdateCostumer(23, "Jørgen");
            costumers.CostumersInList();
            Console.ReadKey(false);
            Console.Clear();
            #endregion
            #region Menu & Customers
            MenuCatalog catalog = new MenuCatalog();
            catalog.PrintMenu();
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Update Pizza, New Pizza & DeletePizza
            catalog.UpdatePizza(65, "Margarita");
            catalog.NewPizza("Tytyty", 100);
            catalog.DeletePizza(catalog.MenuCatalogList1[1]);
            catalog.PrintMenu();
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Order 1
            Order order = new Order(2);
            Console.WriteLine($"{costumers.Costumers[1]}\nHan bestiller {order.NumberOfPizzas} pizzaer.");
            order.AddPizzaToOrder(catalog.MenuCatalogList1[0]);
            order.AddPizzaToOrder(catalog.MenuCatalogList1[2]);
            order.AddPizzaToOrder(catalog.MenuCatalogList1[3]);
            order.RemovePizzaFromOrder(catalog.MenuCatalogList1[3]);
            order.OrderPriceTotal();
            Console.WriteLine(order.ToString());
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Order 2
            Order order2 = new Order(3);
            Console.WriteLine($"{costumers.Costumers[3]}\nHan bestiller {order2.NumberOfPizzas} pizzaer.");
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[0]);
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
                Pizza Pizza = catalog.GetPizza("Yousuck");
                Console.WriteLine("Found pizza: " + Pizza.PizzaName);
            }
            catch (PizzaNotFoundExcep ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey(false);
            Console.Clear();
            try
            {
                Pizza Pizza = catalog.GetPizza("Margarita");
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
