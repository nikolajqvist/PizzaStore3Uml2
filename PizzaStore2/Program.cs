using PizzaStore3;
using System.Data;
using System.Dynamic;

namespace PizzaStore2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore();

            pizzaStore.MenuChoice();
        }
    }
}
