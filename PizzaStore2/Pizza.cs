using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class Pizza
    {
        //I den her class opretter jeg Instancefield, Properties, en contruktor og en ToString.
        //Min kode her bestemmer hvad en pizza skal indeholde.
        private string _pizzaName;
        private int _price;


        //Her bestemmer jeg hvad en pizza skal indeholde.
        public Pizza(string PizzaName, int Price)
        {
            _pizzaName = PizzaName;
            _price = Price;
        }
        //Her er mine properties.
        public string PizzaName { get { return _pizzaName; } }
        public int Price { get { return _price; } }
        //Her sender jeg det ud en pizza skal indeholde.
        public override string ToString()
        {
            return $"{PizzaName} cost {Price}";
        }
    }
}
