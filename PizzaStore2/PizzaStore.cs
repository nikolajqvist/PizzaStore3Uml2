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
            //Opgaver tilbage:
            //Ordreliste
            //Update (pizza, costumer, order)
            //Searchcriteria
            //user dialog.
            //
            //
            //
            MenuCatalog catalog = new MenuCatalog();
            Costumers costumers = new Costumers();
            Order order = new Order();
            catalog.PrintMenu();
            order.AddCostumer(costumers.Costumerss1[0]);
            Console.WriteLine($"{costumers.Costumerss1[0]} bestiller 2 pizzaer en {catalog.MenuList1[0].PizzaName} og en {catalog.MenuList1[1].PizzaName}.");
            order.AddPizzaToOrder(catalog.MenuList1[0]);
            order.AddPizzaToOrder(catalog.MenuList1[1]);
            order.OrderPriceTotal();
            order.RemovePizzaFromOrder(catalog.MenuList1[1]);
            Console.WriteLine(order.ToString());

            Order order2 = new Order();
            order2.AddCostumer(costumers.Costumerss1[1]);
            Console.WriteLine($"{costumers.Costumerss1[1]} bestiller {order2.NumberOfPizzas} pizzaer en {catalog.MenuList1[1]}, en {catalog.MenuList1[2]} og en {catalog.MenuList1[0]}");
            order2.AddPizzaToOrder(catalog.MenuList1[2]);
            order2.AddPizzaToOrder(catalog.MenuList1[1]);
            order2.AddPizzaToOrder(catalog.MenuList1[0]);
            order2.OrderPriceTotal();
            order2.RemoveCostumer(costumers.Costumerss1[1]);
            Console.WriteLine(order2.ToString());

            Console.ReadKey();
        }
    }
}
