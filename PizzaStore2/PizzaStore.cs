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
            //Her udskriver jeg alle kunderne i listen.
            costumers.CostumersInList();
            //Her opretter jeg en ny kunde Jannik som er 41 år gammel.
            costumers.CreateCostumer("Jannik", 41);            
            //Her opdaterer jeg en nuværende kundes oplysninger så han i stedetfor er 23 år gammel.
            costumers.UpdateCostumer(23, "Jørgen");
            //Her udskriver jeg den nye liste af kunder.
            costumers.CostumersInList();
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Menu & Customers
            MenuCatalog catalog = new MenuCatalog();
            //Her printer jeg menuen for pizzaer.
            catalog.PrintMenu();
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Update Pizza, New Pizza & DeletePizza
            //Her opdatere jeg den ene pizza.
            catalog.UpdatePizza(65, "Margarita");
            //Her opretter jeg en ny pizza.
            catalog.NewPizza("Tytyty", 100);
            //Her sletter jeg en eksisterende pizza.
            catalog.DeletePizza(catalog.MenuCatalogList1[1]);
            //Her printer jeg menuen for alle de nuværende pizzaer.
            catalog.PrintMenu();
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Order 1
            //Her opretter jeg ordre nr.1.
            Order order = new Order(2);
            Console.WriteLine($"{costumers.Costumers[1]}\nHan bestiller {order.NumberOfPizzas} pizzaer.");
            //Tilføjer tre pizzaer til ordren
            order.AddPizzaToOrder(catalog.MenuCatalogList1[0]);
            order.AddPizzaToOrder(catalog.MenuCatalogList1[2]);
            order.AddPizzaToOrder(catalog.MenuCatalogList1[3]);
            //Fjerner den ene pizza igen.
            order.RemovePizzaFromOrder(catalog.MenuCatalogList1[3]);
            //Udregner total prisen for ordren.
            order.OrderPriceTotal();
            Console.WriteLine(order.ToString());
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Order 2
            //Her opretter jeg ordre nr.1.
            Order order2 = new Order(3);
            Console.WriteLine($"{costumers.Costumers[3]}\nHan bestiller {order2.NumberOfPizzas} pizzaer.");
            //Tilføjer tre pizzaer til ordren
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[0]);
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[2]);
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[3]);
            //Udregner total prisen for ordren.
            order2.OrderPriceTotal();
            Console.WriteLine(order2.ToString());
            Console.ReadKey(false);
            Console.Clear();
            #endregion

            #region Try and Catch Exception

            //Her finder jeg ud af om vi har pizzaen "Yousuck" i menuen og den viser at vi ikke har den.
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
            //Her finder jeg ud af om vi har pizzaen "Margarita" i menuen og det har vi og derfor får vi udskrevet "Found pizza + pizzaName.
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
