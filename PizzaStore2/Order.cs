using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class Order
    {
        #region Instance Field
        private Pizza _pizza;
        private Costumer _name;
        private Pizza _price;
        private int _totalPrice;
        private int _orderId;
        private int _orderNumber;
        private static int _idcounter = 0;
        private DateTime _date;
        private int _delivery = 40;
        private int _numberOfPizzas;
        private List<Pizza> _pizzaList = new List<Pizza>();
        private List<Costumer> _costumerList = new List<Costumer>();
        #endregion

        #region Constructor
        public Order(int NumberOfPizzas) 
        {
            _orderId = _idcounter;
            _idcounter++;
            _pizza = Pizza;
            _name = Name;
            _totalPrice += _delivery;
            _date = DateTime.Now;
            _price = Price;
            _numberOfPizzas = NumberOfPizzas;
        }
        #endregion

        #region Properties
        public Pizza Pizza { get => _pizza; set => _pizza = value; }
        public Costumer Name { get => _name; set => _name = value; }
        public Pizza Price { get => _price; set => _price = value; }
        public int TotalPrice { get { return _totalPrice; } }
        public DateTime Date { get { return _date; } }
        public int OrderId { get => _orderId; private set => _orderId = value; }
        public int OrderNumber { get { return _orderNumber; } }
        public int NumberOfPizzas { get => _numberOfPizzas; set => _numberOfPizzas = value; }
        #endregion

        #region Methods
        public void UpdatePizza(int newPrice, string name)
        {
            for (int i = 0; i < _pizzaList.Count; i++)
            {
                if (string.Equals(_pizzaList[i].PizzaName, name, StringComparison.OrdinalIgnoreCase))
                {
                    _pizzaList[i].Price = newPrice;
                }
            }
        }
        public void AddPizzaToOrder(Pizza Pizza)
        {
            _pizzaList.Add(Pizza);
        }
        public void RemovePizzaFromOrder(Pizza Pizza)
        {
            Console.WriteLine("Fortrudt valg.");
            _pizzaList.Remove(Pizza);
        }
        public void OrderPriceTotal()
        {
            foreach (Pizza pizza in _pizzaList)
            {
                _totalPrice += pizza.Price;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Pizza pizza in _pizzaList)
            {
                sb.AppendLine(pizza.ToString());
            }

            sb.AppendLine($"OrderID: {OrderId}. Totalprice:{_totalPrice}");

            return sb.ToString();
        }
        #endregion
    }
}
