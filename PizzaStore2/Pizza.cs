using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class Pizza
    {
        #region Instance Fields
        private string _pizzaName;
        private int _price;
        #endregion

        #region Construktor
        public Pizza(string PizzaName, int Price)
        {
            _pizzaName = PizzaName;
            _price = Price;
        }
        #endregion

        #region Properties
        public string PizzaName { get { return _pizzaName; } set { _pizzaName = value; } }
        public int Price { get => _price; set => _price = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{PizzaName} costs {Price}kr.";
        }
        #endregion
    }
}
