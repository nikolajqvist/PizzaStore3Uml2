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
        //Her opretter jeg min Start metode som jeg så skriver alle mine pizzaer, costumers og ordre i også udskriver jeg det hele.
        public void Start()
        {
            //Når man kalder en costruktor med objekter i skal den puttes i en metode.
            //Her opretter jeg alle mine objekter til mine classes.
            Pizza pizza1 = new Pizza("Margarita", 100);
            Costumer cos1 = new Costumer("Mogens", 56);
            Order order1 = new Order(pizza1, cos1, 1);
            order1.CalculateTotalPrice();
            Console.WriteLine(order1);

            Pizza pizza2 = new Pizza("Pepperoni", 100);
            Costumer cos2 = new Costumer("Vibeke", 51);
            Order order2 = new Order(pizza2, cos2, 2);
            order2.CalculateTotalPrice();
            Console.WriteLine(order2);

            Pizza pizza3 = new Pizza("Meatzzo", 100);
            Costumer cos3 = new Costumer("Camilla", 41);
            Order order3 = new Order(pizza3, cos3, 4);
            order3.CalculateTotalPrice();
            Console.WriteLine(order3);

            Console.ReadKey();
            
        }
    }
}
