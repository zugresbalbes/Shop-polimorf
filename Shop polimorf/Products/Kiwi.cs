using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_polimorf.Products
{
    class Kiwi : Product
    { 
        public Kiwi(string name, int price, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }
        public override string ToString()
        {
            return "Зеленый киви";
            return "Желтый киви";
        }
        
    }
}
