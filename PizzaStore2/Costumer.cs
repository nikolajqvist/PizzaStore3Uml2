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
        //I den her class opretter jeg Instancefield, Properties, en contruktor og en ToString.
        //Min kode her bestemmer hvad en costumer skal indeholde. "Ved godt jeg har stavet costumer forkert"
        private string _costumerName;
        private int _age;
        private string _adress;


        //Her bestemmer jeg hvad en Costumer skal indeholde.
        public Costumer(string CostumerName, int Age)
        {
            _costumerName = CostumerName;
            _age = Age;
            _adress = Adress;
        }
        //Her har jeg lavet properties.
        public string CostumerName { get { return _costumerName; } }
        public int Age { get { return _age; } }

        public string Adress { get => _adress; private set => _adress = value; }
        //Her udskriver jeg hvad costumer skal indeholde.
        public override string ToString()
        {
            return $"{CostumerName}";
        }
    }
}
