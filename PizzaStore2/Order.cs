using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class Order
    {
        //I den her class opretter jeg en ordre med hjælp fra Pizza.cs og Costumer.cs. Har lavet det sådan så en ordre ikke kan oprettes uden en Pizza, en kunde 
        // og hvor mange pizzaer de vil have.
        private Pizza _pizza;
        private Costumer _name;
        private Pizza _price;
        private int _totalPrice;
        private int _orderId;
        private int _orderNumber;
        private static int _idcounter = 0;
        private DateTime _date;
        private int _numberOfPizza;



        ///Her er hvad en ordre skal indeholde
        public Order(Pizza Pizza, Costumer Name, int NumberOfPizza) 
        {
            _orderId = _idcounter;
            _idcounter++;
            _pizza = Pizza;
            _name = Name;
            _totalPrice = TotalPrice;
            _date = DateTime.Now;
            _price = Price;
            _numberOfPizza = NumberOfPizza;

        }
        //Det her er mine properties.
        public Pizza Pizza { get => _pizza; set => _pizza = value; }
        public Costumer Name { get => _name; set => _name = value; }
        public Pizza Price { get => _price; set => _price = value; }
        public int TotalPrice { get { return _totalPrice; } }
        public DateTime Date { get { return _date; } }
        public int NumberOfPizza { get { return _numberOfPizza; } }
        public int OrderId { get => _orderId; private set => _orderId = value; }
        public int OrderNumber { get { return _orderNumber; } }
        
        //Her laver jeg en metode som udregner hele prisen for ordren.
        public void CalculateTotalPrice()
        {
            _totalPrice = Pizza.Price * NumberOfPizza + 40;
        }
        //Her udskriver jeg hvad en ordre skal indeholde.  \n giver mellemrum.
        public override string ToString()
        {
            return $"Ordernr:{OrderId} Tid:{Date}. {Pizza} kr.\n" +
                $" + 40 kr. in shipping and the total price is" +
                $" {TotalPrice} kr. \n and there is {NumberOfPizza} pizzas. For {Name}!";
        }
    }
}
