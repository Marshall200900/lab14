using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopLibrary;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            ReqCollection shop = new ReqCollection(10);
            shop.Generate(5);

            ReqCollection shop2 = new ReqCollection(10);
            shop2.Generate(5);

            Console.WriteLine("Коллекция shop");
            shop.Show();
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Коллекция shop");
            shop.Show();
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Наименование всех товаров в заданном отделе магазина.");
            foreach(var a in shop.NamesOfGoods("молочный"))
            {
                Console.WriteLine(a);
            }
            Console.Write("Количество товаров в молочном отделе: ");
            Console.WriteLine(shop.GetNumberOfGoods("молоко"));

            Console.WriteLine("Пересечение");
            foreach (var a in shop.Intersect(shop2))
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Исключение");
            foreach (var a in shop.Except(shop2))
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Объединение");
            foreach (var a in shop.Concat(shop2))
            {
                Console.WriteLine(a);
            }

        }
    }
}
