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

        public static Shop Instance => _instance;
        private Shop()
        {
            _product = new Product[50];
        }

        public void ListProducts()
        {
            Console.WriteLine("Which section would you like to see?\n1. History\n2. Sci-Fi\n3. Fantasy\n4. Philosophy\n5. Politics\n\nEnter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
        }

        public void FillTheShop(Product product)
        {
            for (; _index < _product.Length; _index++)
            {
                ShopFiller.Instance.GetProduct(_index, ref product);

               _product[_index] = product;
            }
        }
    }
}
