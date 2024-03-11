using System.Dynamic;

namespace PizzaStore2
{
    internal class Program
    {
        //Her opretter jeg et objekt for alle classes så Main ved hviken class den skal lede efter
        //Også opretter jeg PizzaStore.cs herinde og kalder min metode Start(), så udskriver jeg det hele.
        public static void Main(string[] args)
        {
            Costumer cos = new Costumer("", 0);
            Pizza pizza = new Pizza("", 0);
            Order order = new Order(pizza,cos, 0);
            PizzaStore pizzastore = new PizzaStore();

            pizzastore.Start();
            Console.WriteLine();
        }
    }
}
