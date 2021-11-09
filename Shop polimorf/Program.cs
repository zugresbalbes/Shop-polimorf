using System;
using Shop_polimorf.Products;

namespace Shop_polimorf
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Zugres",
                "ул. Куты Легиан, д.23",
                5000,
                500
                );
            Console.WriteLine("Список товаров:");

            

            Orange orange = new Orange(
                "Красный",
                150,
                "Восточная Ферма"
                );

            Apple apple = new Apple(
               "Муцу",
               300,
               "Центральная Ферма"
               );
            
            Kiwi kiwigreen = new Kiwi(
               "Зеленый киви",
               250,
               "Ферма Дяди Васи"
               );


            Kiwi kiwiyellow = new Kiwi(
                "Желтый киви",
                400,
                "Ферма Любви"
                );

            Banana banana = new Banana(
               "Банан",
               50,
               "Ферма Любви"
               );


            Product[] products = new Product[] {
                orange,
                apple,
                kiwigreen,
                kiwiyellow,
                banana
            };

            Informer informer = new Informer();
           
            foreach (Product product in products)
            {
                product.ToConsole();
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name} ваш баланс {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }
               
               
            }
        }
    }
}

