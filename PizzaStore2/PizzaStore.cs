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
            //Order (create, delete, update)
            //Update (costumer, order)
            //Implamentere costumer.
            //Searchcriteria
            //user dialog.
            MenuCatalog catalog = new MenuCatalog();
            Costumersadmin costumers = new Costumersadmin();
            catalog.PrintMenu();
            Order order = new Order(2);
            //costumers.UpdateCostumer("", "");
            order.UpdatePizza(65, "Meatzza");
            
            //costumers.AddCostumer(costumers.Costumerss1[0]);
            Console.WriteLine($"{costumers.Costumerss1[0]}\nHan bestiller {order.NumberOfPizzas} pizzaer.");
            order.AddPizzaToOrder(catalog.MenuCatalogList1[0]);
            order.AddPizzaToOrder(catalog.MenuCatalogList1[1]);
            order.OrderPriceTotal();
            Console.WriteLine(order.ToString());
            Console.ReadKey(false);
            Console.Clear();
            
            Order order2 = new Order(2);
            //costumers.AddCostumer(costumers.Costumerss1[1]);
            Console.WriteLine($"{costumers.Costumerss1[1]}\nHan bestiller: {order2.NumberOfPizzas} pizzaer.");
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[2]);
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[1]);
            order2.AddPizzaToOrder(catalog.MenuCatalogList1[0]);
            order2.OrderPriceTotal();
            Console.WriteLine(order2.ToString());

            

            Console.ReadKey();
        }
    }
}
