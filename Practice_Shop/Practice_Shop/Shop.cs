using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Shop
{
    public class Shop
    {
        private static Shop _instance = new Shop(); 
        private Product[] _product;
        private int _index;
        private int _count;

        public static Shop Instance => _instance;

        private Shop()
        {
            _product = new Product[50];
            _index = 0;
            _count = 0;
            RealFill(ref  _product);
        }

        public void ListProducts()
        {
            Console.Clear();
            Console.WriteLine("Which section would you like to see?\n1. History\n2. Sci-Fi\n3. Fantasy\n4. Philosophy\n5. Politics\n\nEnter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            ProductType choice;

            switch (number)
            {
                case 1:
                    choice = ProductType.History;
                    Console.Clear();
                    ListSection(ref _product, choice);
                    break;
                case 2:
                    choice = ProductType.SciFi;
                    Console.Clear();
                    ListSection(ref _product, choice);
                    break;
                case 3:
                    choice = ProductType.Fantasy;
                    Console.Clear();
                    ListSection(ref _product, choice);
                    break;
                case 4:
                    choice = ProductType.Philosophy;
                    Console.Clear();
                    ListSection(ref _product, choice);
                    break;
                case 5:
                    choice = ProductType.Politics;
                    Console.Clear();
                    ListSection(ref _product, choice);
                    break;
                default:
                    Console.WriteLine("There's no such section! Try again?");
                    Console.ReadKey();
                    Console.Clear();
                    ListProducts();
                    break;
            }
        }

        public void FillTheShop(ref Product product)
        {
            ShopFiller filler = new ShopFiller();

            for (; _index < _product.Length; _index++)
            {
                _product[_index] = new Product();
                filler.GetProduct(_index, ref _product[_index]);
            }
        }

        private void ListSection(ref Product[] _product, ProductType currentType)
        {
            Console.Clear();
            foreach (Product productItem in _product)
            {
                if (productItem.Type == currentType)
                {
                    Console.WriteLine($"{productItem.ProductId}. {productItem.ProductName}  : {productItem.Price} UAH");
                }
            }

            ShowDescription(currentType);
        }

        private void RealFill(ref Product[] _product)
        {
            for (int i = 0; i < _product.Length; i++)
            {
                FillTheShop(ref _product[i]);
            }
        }

        private void ShowDescription(ProductType currentType)
        {
            Console.WriteLine("\nAre you interested in any of these books? If yes, print its number to read description. If no, print 0");
            int num = Convert.ToInt32(Console.ReadLine()) - 1;

            if (num == -1)
            {
                Console.Clear();
                ListProducts();
            }
            else if (num < -1 || num >= _product.Length)
            {
                ThrowError1();
            }
            else if (_product[num].Type != currentType)
            {
                ThrowError1();
            }
            else if (_product[num].Type == currentType)
            {
                Console.Clear();
                Console.WriteLine($"{_product[num].ProductDescription}\n");
                DecideWhetherToBuy(currentType, num);
            }
        }

        private void DecideWhetherToBuy(ProductType currentType, int num)
        {
            Console.WriteLine("So, what`s your decision?\n1. Put into basket!\n2. Return to the section.\n3. Return to the shop`s first page.\n");
            Console.Write("Print: ");
            int dec = Convert.ToInt32(Console.ReadLine());

            switch (dec)
            {
                case 1:
                    if (_count < 10)
                    {
                        Order.Instance.AddToOrder(_product[num]);
                        _count++;
                        ContinueShopping(currentType);
                    }
                    else
                    {
                        Console.WriteLine("Your basket is full!");
                        Console.ReadKey();
                        Order.Instance.ListOrder();
                    }
                    break;
                case 2:
                    Console.Clear();
                    ListSection(ref _product, currentType);
                    break;
                case 3:
                    Console.Clear();
                    ListProducts();
                    break;
                default:
                    Console.WriteLine("Stop trying to break my shop!");
                    break;
            }
        }

        private void ContinueShopping(ProductType currentType)
        {
            Console.WriteLine("Great! The book is added to your basket!\n\nWould you like to:\n1. Continue shopping in this section\n2. Continue shopping in another section\n3. Check my basket\n4. Check my account");
            Console.Write("Print: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            switch (temp)
            {
                case 1:
                    ListSection(ref _product, currentType);
                    break;
                case 2:
                    Console.Clear();
                    ListProducts();
                    break;
                case 3:
                    Console.Clear();
                    Order.Instance.ListOrder();
                    break;
                case 4:
                    Console.Clear();
                    Customer.Instance.PrintCustomerInfo();
                    Console.ReadKey();
                    ListProducts();
                    break;
                default:
                    Console.WriteLine("Error!");
                    Console.ReadKey();
                    Console.Clear();
                    ContinueShopping(currentType);
                    break;
            }
        }

        private void ThrowError1()
        {
            Console.WriteLine("Error!");
            Console.ReadKey();
            Console.Clear();
            ListProducts();
        }
    }
}
