using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore3
{
    public class PizzaNotFoundExcep : Exception
    {
        public PizzaNotFoundExcep()
        {
            
        }
        public PizzaNotFoundExcep(string message) : base(message)
        {

        }
    }
}
