using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Shop
{
    public class Shop
    {
        private Product[] _product;
        private int _index;

        public Shop()
        {
            _product = new Product[50];
            FillTheShop(ref _product);
        }

        public void ListProducts()
        {
            Console.WriteLine("Which section would you like to see?\n1. History\n2. Sci-Fi\n3. Fantasy\n4. Philosophy\n5. Politics\n\nEnter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            ProductType choice;

            if (number == 1)
            {
                choice = ProductType.History;
                ListSection(_product, choice);
            }
            else if (number == 2)
            {
                choice = ProductType.SciFi;
                ListSection(_product, choice);
            }
            else if (number == 3)
            {
                choice = ProductType.Fantasy;
                ListSection(_product, choice);
            }
            else if (number == 4)
            {
                choice = ProductType.Philosophy;
                ListSection(_product, choice);
            }
            else if (number == 5)
            {
                choice = ProductType.Politics;
                ListSection(_product, choice);
            }
            else
            {
                Console.WriteLine("There`s no such section! Try again?");
                Console.ReadKey();
                ListProducts();
            }
        }

        public void FillTheShop(ref Product[] _product)
        {
            ShopFiller filler = new ShopFiller();

            for (; _index < _product.Length; _index++)
            {
                filler.GetProduct(_index, _product[_index]);
            }
        }

        private void ListSection(Product[] product, ProductType currentType)
        {
            foreach (Product productItem in product)
            {
                if (productItem.Type == currentType)
                {
                    Console.WriteLine($"{productItem.ProductId}. {productItem.ProductName}, ");
                }
            }
        }
    }
}
