using PizzaStore2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore3
{
    public class Costumersadmin
    {
        private List<Pizza> _pizzaList = new List<Pizza>();
        private List<Costumer> Costumerss = new List<Costumer>()
        {
                new Costumer("Jørgen", 56),
                new Costumer("Ulrik", 44),
                new Costumer("Jannik", 23)
        };

        public List<Costumer> Costumerss1 { get => Costumerss; set => Costumerss = value; }
        public List<Pizza> PizzaList { get => _pizzaList; set => _pizzaList = value; }

        public void AddCostumer(Costumer costumer)
        {
            Costumerss.Add(costumer);
        }
        public void RemoveCostumer(Costumer costumer)
        {
            Costumerss.Remove(costumer);
        }
        //public void UpdateCostumer(string newName, string name)
        //{
        //    for (int i = 0; i < Costumerss1.Count; i++)
        //    {
        //        if (string.Equals(Costumerss1[i].CostumerName, name, StringComparison.OrdinalIgnoreCase))
        //        {
        //            Costumerss1[i].CostumerName = newName;
        //        }
        //    }
        //}
    }

}
