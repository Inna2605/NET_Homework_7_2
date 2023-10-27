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
    internal class Shop:TypeShop, IDisposable
    {
        public string Name {  get; set; }
        public string Address { get; set; }
        public TypeShop TypeShop;
        public void InputTypeShop()
        {
            Console.WriteLine("\nОберіть тип магазину:\n" +
                "1. Продовольчий;\n" +
                "2. Господарський;\n" +
                "3. Одягу;\n" +
                "4. Взуття.\n");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.Write("Магазин ");
                        TypeShop typeShop = new TypeShop();
                        typeShop.Food = "Продовольчий";
                        typeShop.ShowFood();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Магазин ");
                        TypeShop typeShop = new TypeShop();
                        typeShop.Household = "Господарський";
                        typeShop.ShowHousehold();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Магазин ");
                        TypeShop typeShop = new TypeShop();
                        typeShop.Clothing = "Одягу";
                        typeShop.ShowClothing();
                        break;
                    }
                case 4:
                    {
                        Console.Write("Магазин ");
                        TypeShop typeShop = new TypeShop();
                        typeShop.Shoes = "Взуття";
                        typeShop.ShowShoes();
                        break;
                    }
            }
        }
        public void Show()
        {
            Console.Write($"Назва магазину: {Name}\nАдреса магазину: {Address}");
        }
        public void Dispose()
        {
            Console.WriteLine("\n\nВідпрацювання метода Dispose()");
        }
    }
}
