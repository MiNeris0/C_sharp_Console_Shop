using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Shop
{
    public class Customer
    {
        private readonly string _username;
        private int _cash;
        private readonly int _id;

        public string Username { get { return _username; } }
        public int Id { get { return _id; } }
        public int Cash { get { return _cash; } }

        public Customer(string username, int cash)
        {
            _username = username;
            _cash = cash;
            _id = new Random().Next(0, int.MaxValue);
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine("\nCustomer: " + Username + "\nCustomer id: " + Id + "\nAvaliable money: " + Cash + "\n");
        }
    }
}
