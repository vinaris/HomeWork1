using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст кошки: ");
            string age = Console.ReadLine();
            var color = new CatColor();
            var cat = new Cat(age, color);
            while (true)
            {
                Console.WriteLine("Текущая информация о кошке.\nИмя: " + cat.Name + "\nВозраст: " + cat.Age + "\nТекущий цвет: " + cat.CurrentColor);
                Console.WriteLine("Выберите действие:\n1. Задать имя\n2. Задать цвет\n3. Ударить\n4. Покормить\n5. Выход");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Write("Введите имя кошке: ");
                        cat.Name = Console.ReadLine();
                        break;

                    case "2":
                        Console.Write("Введите цвет здоровой кошки: ");
                        cat.Color.HeathyColor = Console.ReadLine();
                        Console.Write("Введите цвет больной кошки: ");
                        cat.Color.SickColor = Console.ReadLine();
                        cat.SetCurrentColor();
                        break;

                    case "3":
                        cat.Punish();
                        cat.SetCurrentColor();
                        break;

                    case "4":
                        cat.Feed();
                        cat.SetCurrentColor();
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Такого пункта нет!");
                        break;

                }
            }
        }
    }
}
