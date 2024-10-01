using System;
using System.Collections.Generic;

namespace Bridge.RealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customers = new Customers();
            customers.Data = new CustomersData("Chicago");
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();
            Console.ReadKey();
        }
    }
    public class CustomersBase
    {
        private DataObject dataObject;
        public DataObject Data
        {
            set { dataObject = value; }
            get { return dataObject; }
        }
        public virtual void Next()
        {
            dataObject.NextRecord();
        }
        public virtual void Prior()
        {
            dataObject.PriorRecord();
        }
        public virtual void Add(string customer)
        {
            dataObject.AddRecord(customer);
        }
        public virtual void Delete(string customer)
        {
            dataObject.DeleteRecord(customer);
        }
        public virtual void Show()
        {
            dataObject.ShowRecord();
        }
        public virtual void ShowAll()
        {
            dataObject.ShowAllRecords();
        }
    }

    public class Customers : CustomersBase
    {
        public override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }

    public abstract class DataObject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract string GetCurrentRecord();
        public abstract void ShowRecord();
        public abstract void ShowAllRecords();
    }
    public class CustomersData : DataObject
    {
        private readonly List<string> customers = new List<string>();
        private int current = 0;
        private string city;

        public CustomersData(string city)
        {
            this.city = city;
            customers.Add("Jim Jones");
            customers.Add("Samual Jackson");
            customers.Add("Allen Good");
            customers.Add("Ann Stills");
            customers.Add("Lisa Giolani");
        }
        public override void NextRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }
        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }
        public override void AddRecord(string customer)
        {
            customers.Add(customer);
        }
        public override void DeleteRecord(string customer)
        {
            customers.Remove(customer);
        }
        public override string GetCurrentRecord()
        {
            return customers[current];
        }
        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }
        public override void ShowAllRecords()
        {
            Console.WriteLine("Customer City: " + city);

            foreach (string customer in customers)
            {
                Console.WriteLine(" " + customer);
            }
        }
    }
}
