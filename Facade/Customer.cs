using System;

namespace Facade.RealWorld
{
    public class Customer
    {
        private string name;

        // Constructor
        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
