using System;

namespace Facade.RealWorld
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true; // Simulate good credit
        }
    }
}
