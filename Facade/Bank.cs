using System;

namespace Facade.RealWorld
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true; // Simulate sufficient savings
        }
    }
}
