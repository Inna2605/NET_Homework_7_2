//Завдання 2: Створіть клас «Магазин», який має зберігати таку інформацію:
// назва магазину;  адреса магазину;  тип магазину: o продовольчий, o господарський, o одяг, o взуття.
//Реалізуйте у класі методи та властивості, необхідні для функціонування класу.
//Клас має реалізовувати інтерфейс IDisposable.
//Напишіть код для тестування функціональності класу.
//Напишіть код для виклику методу Dispose.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_7_2
{
    internal class TypeShop
    {
        public string Food {  get; set; }
        public string Household {  get; set; }
        public string Clothing {  get; set; }
        public string Shoes {  get; set; }

        public void ShowFood()
        {
            Console.WriteLine(Food);
        }
        public void ShowHousehold()
        {
            Console.WriteLine(Household);
        }
        public void ShowClothing()
        {
            Console.WriteLine(Clothing);
        }
        public void ShowShoes()
        {
            Console.WriteLine(Shoes);
        }
    }
}
