using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Atividade01.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { private get;  set; }
        public int TotalQuantity { get; private set; }

        public Product(string name, double price, int quantity, int totalQuantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            TotalQuantity = totalQuantity;
        }

        public Product(int quantity)
        {
            Quantity = quantity;
        }

        public Product()
        {
        }

        public void AddStock()
        {
            TotalQuantity += Quantity;   
        }

        public void RemoveStock(int qtde)
        {
            if(qtde < TotalQuantity)
            {
                Quantity -= qtde;
                TotalQuantity -= qtde;
            }
        }

        public void StockTotal()
        {
            double stockPrice = Price * TotalQuantity;
            Console.WriteLine("Price total stock: " + stockPrice.ToString("F2", CultureInfo.InvariantCulture));
        }

        override public string ToString()
        {
            return "Name: " + Name + ", Price: " + Price + ", Quantity: " + Quantity + ", Total Quantity: " + TotalQuantity;
        }
    }
}
