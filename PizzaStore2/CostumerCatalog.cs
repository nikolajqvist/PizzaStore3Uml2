using PizzaStore2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore3
{
    public class CostumerCatalog
    {
        private Costumer _costumer;

        public CostumerCatalog()
        {
            _costumer = Costumer;
        }
        private List <Costumer> _costumers = new List<Costumer>
            {
                new Costumer("Jørgen", 56),
                new Costumer("Ulrik", 23),
                new Costumer("Knud", 88)
            };
        public List<Costumer> Costumers { get => _costumers; set => _costumers = value; }
        public Costumer Costumer { get => _costumer; set => _costumer = value; }
        public void CreateCostumer(string name, int age)
        {
            _costumer = new Costumer(name, age);
            _costumers.Add(_costumer);
        }
        public void AddCostumerToList(Costumer costumer)
        {
            _costumers.Add(costumer);
        }
        public void UpdateCostumer(int updateAge, string name)
        {
            Console.WriteLine("New costumer list:");
            for (int i = 0; i < Costumers.Count; i++)
            {
                if (string.Equals(Costumers[i].Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    Costumers[i].Age = updateAge;
                }
            }
        }
        public void DeleteCostumer(Costumer costumer)
        {
            _costumers.Remove(costumer);
        }
        public void CostumersInList()
        {
            foreach (Costumer costumer in Costumers)
            {
                Console.WriteLine($"{costumer}");
            }
            Console.WriteLine();
        }
    }
}
