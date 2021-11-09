using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_polimorf
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 100)
            {
                return Price;
            }
            if (user.Spent < 300)
            {
                return Price * 0.9;
            }
            return Price * 0.8;
        }

             public virtual void ToConsole()
        {
            Console.WriteLine(ToString() + ":");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price.ToString());
            Console.WriteLine("Производитель: " + Manufacturer);
        }
    }
    }

