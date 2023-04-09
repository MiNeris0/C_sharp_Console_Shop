using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Shop
{
    public class Order
    {
        private static Order _instance = new Order();
        private int _sum;
        private int _count;
        private readonly Guid _id;

        public static Order Instance => _instance;
        public Product[] FinalOrder { get; set; }

        private Order()
        {
            FinalOrder = new Product[10];
            _sum = 0;
            _id = Guid.NewGuid();
        }

        public void AddToOrder(Product product)
        {
            FinalOrder[_count] = product;
            _count++;
            _sum += product.Price;
        }

        public void ClearOrder()
        {
            for (int i = 0; i < FinalOrder.Length; i++)
            {
                FinalOrder[i] = null;
            }

            _count = 0;
            _sum = 0;
        }

        public void ListOrder()
        {
            Console.Clear();
            Console.WriteLine("You have already put in your basket:\n");

            ReturnOrderList();
            
            Console.WriteLine("What do you want to do?\n1. Make an order\n2. Continue shopping\n3. Clear basket");
            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Customer.Instance.Cash -= _sum;
                    CompleteOrder();
                    break;
                case 2:
                    Shop.Instance.ListProducts();
                    break;
                case 3:
                    ClearOrder();
                    Console.WriteLine("All items were deleted from your basket.\n");
                    Console.ReadKey();
                    Console.Clear();
                    Customer.Instance.PrintCustomerInfo();
                    Console.ReadKey();
                    Shop.Instance.ListProducts();
                    break;
                default:
                    Console.WriteLine("If you don`t know what you want, neither do I!");
                    Console.ReadKey();
                    Shop.Instance.ListProducts();
                    break;
            }
        }

        private void CompleteOrder()
        {
            Console.Clear();
            ReturnOrderList();
            
            if (Customer.Instance.Cash >= _sum)
            {
                Console.WriteLine($"Order: {_id}\nOrder formed. Have a nice day!");
            }
            else
            {
                Console.WriteLine("You don`t have enough money to pay. ");
            }
        }

        private void ReturnOrderList()
        {
            for (int i = 0, j = 1; i < _count; i++, j++)
            {
                Console.WriteLine($"{j}. {FinalOrder[i].ProductName}, {FinalOrder[i].Type} genre, {FinalOrder[i].Price} UAH");
            }

            Console.WriteLine($"\nTotal sum: {_sum} UAH\n\nYour account: {Customer.Instance.Cash} UAH");
        }
    }
}
