//Завдання 2: Створіть клас «Магазин», який має зберігати таку інформацію:
// назва магазину;  адреса магазину;  тип магазину: o продовольчий, o господарський, o одяг, o взуття.
//Реалізуйте у класі методи та властивості, необхідні для функціонування класу.
//Клас має реалізовувати інтерфейс IDisposable.
//Напишіть код для тестування функціональності класу.
//Напишіть код для виклику методу Dispose.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Shop shop = new Shop();

            Console.Write("Введіть назву магазину: ");
            shop.Name = Console.ReadLine();

            Console.Write("Введіть адресу магазину: ");
            shop.Address = Console.ReadLine();

            shop.InputTypeShop();
            shop.Show();

           //shop.Dispose();//безпосередньо виклик методу Dispose() через об'єкт

            using(shop)
            {
                Console.WriteLine("\n\n\nВідпрацювання конструкції using");
            }

            Console.ReadLine();
        }
    }
}
