using System;

namespace Facade.RealWorld
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true; // Simulate no bad loans
        }
    }
}
