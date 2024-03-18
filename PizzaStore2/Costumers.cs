using PizzaStore2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore3
{
    public class Costumers
    {
        List<Costumer> Costumerss = new List<Costumer>()
        {
            new Costumer("Jørgen", 56),
            new Costumer("Ulrik", 44),
            new Costumer("Jannik", 23)
        };

        public List<Costumer> Costumerss1 { get => Costumerss; set => Costumerss = value; }
    }
}
