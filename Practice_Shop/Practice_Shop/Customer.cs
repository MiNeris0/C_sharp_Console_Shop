using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Shop
{
    public class Customer
    {
        private static Customer _instance = new Customer();
        private string _username;
        private readonly int _id;

        public static Customer Instance => _instance;
        public string Username { get { return _username; } }
        public int Id { get { return _id; } }
        public int Cash { get; set; }

        private Customer()
        {
            _id = new Random().Next(0, int.MaxValue);
        }

        public void FillCustomerInfo(string username, int cash)
        {
            _username = username;
            Cash = cash;
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine("\nCustomer: " + Username + "\nCustomer id: " + Id + "\nAvaliable money: " + Cash + "\n");
        }
    }
}
