using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Shop
{
    public static class Starter
    {
        public static void Run()
        {
            Console.WriteLine("Good day, friend! Would you like to visit my book shop? (Y / N)");
            string answer = Console.ReadLine();

            if (answer == "Y" || answer == "y" || answer == "Yes" || answer == "yes")
            {
                Start();
            }
            else
            {
                Console.WriteLine("Good bye and watch your back!");
            }
        }
        public static void Start()
        {
            CreateCustomer();

            Customer.Instance.PrintCustomerInfo();
            Console.WriteLine("So, come in, friend.");
            Console.ReadKey();
            Shop.Instance.ListProducts();
        }

        private static void CreateCustomer()
        {
            Console.WriteLine("You need to make shop-account.\nPlease, print your nickname: ");
            string name = Console.ReadLine();
            Console.WriteLine("Great, and how much money do you want to deposit into the account?");
            int cash = Convert.ToInt32(Console.ReadLine());

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name should contain at least 1 character!");
                CreateCustomer();
            }
            else if (cash < 0)
            {
                Console.WriteLine("You should deposit at least 1 coin!");
                CreateCustomer();
            }

            Customer.Instance.FillCustomerInfo(name, cash);
        }
    }
}
