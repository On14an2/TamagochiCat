using System;
using tamagochi;

namespace tamagochi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имя кота:");
            string name = Console.ReadLine();
            Console.WriteLine("Здоровье кота:");
            int healh = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько начальной сытости получил?");
            int heath = int.Parse(Console.ReadLine());
            Cat mycat = new Cat(name, healh);
            while (mycat.IsAlive())
            {
                Console.WriteLine("Что бы вы хотели что бы кот сделал? \n 1: Покормить кота \n 2: Помяукать \n 3:Поиграть \n 4: Информация о коте \n");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                ConsoleKey key1;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("Чем вы хотите накормить кота?");
                        string type = Console.ReadLine();
                        Food newfood = new Food { heath = heath, type = type };
                        DoMeal(mycat, newfood);
                        mycat.Meow();
                        break;
                    case ConsoleKey.D2:
                        mycat.Meow();
                        break;

                    case ConsoleKey.D4:
                        Cat.Info(mycat);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Как ты хочешь что бы кот играл?");
                        Console.WriteLine("1: Играть с игрушкой \n 2: Бегать за игрушечной мышкой \n");
                        key1 = Console.ReadKey().Key;
                        switch (key1)
                        {
                            case ConsoleKey.D1:
                                mycat.Play();
                                break;
                            case ConsoleKey.D2:
                                mycat.Run();
                                break;
                        }

                        break;

                }
            }
            static void DoMeal(Cat c, Food f)
            {
                c.Eat(f);
            }
        }
    }
}