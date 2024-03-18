using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class Costumer
    {
        private string _costumerName;
        private int _age;
        private string _adress;
        public Costumer(string CostumerName, int Age)
        {
            _costumerName = CostumerName;
            _age = Age;
            _adress = Adress;
        }
        public string CostumerName { get { return _costumerName; } }
        public int Age { get { return _age; } }

        public string Adress { get => _adress; private set => _adress = value; }


        public override string ToString()
        {
            return $"{CostumerName}";
        }
    }
}
