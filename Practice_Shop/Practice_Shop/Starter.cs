using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Shop
{
    public class Starter
    {
        public static void Run()
        {
            Console.WriteLine("You need to make shop-account.\nPlease, print your nickname: ");
            string name = Console.ReadLine();
            Console.WriteLine("Great, and how much money do you want to deposit into the account?");
            int cash = Convert.ToInt32(Console.ReadLine());

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name should contain at least 1 character!");
            }

            if (cash < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(cash), "You should deposit at least 1 coin!");
            }

            Customer customer = new Customer(name, cash);
            customer.PrintCustomerInfo();

        }
    }
}
