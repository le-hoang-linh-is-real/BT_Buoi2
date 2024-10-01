using System;

namespace Bridge.RealWorld
{
    public class Customers : CustomersBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
