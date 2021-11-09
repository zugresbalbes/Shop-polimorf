using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_polimorf.Products
{
    class Banana : Product
    {
        public Banana(string name, int price, string manufacturer)
    {
        Name = name;
        Manufacturer = manufacturer;
        Price = price;
    }
        public override string ToString()
        {
            return "Банан";
        }
    }
}
