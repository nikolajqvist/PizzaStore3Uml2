using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore3
{
    public class Costumer
    {
        private string _name;
        private int _age;

        public Costumer(string name, int age)
        {
            _age = age;
            _name = name;
        }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }
}
