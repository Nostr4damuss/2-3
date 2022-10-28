using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения ");
            Console.WriteLine("3. Вывод делителей числа ");
            Console.WriteLine("4. Закрыть программу ");


            while (true)
            {
                Console.WriteLine("Что желаешь выбрать?");
                int a = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (a)
                {
                    case 1:
                        {
                            result = pervayaproga();
                            break;
                        }
                    case 2:
                        {
                            result = vtorayaproga();
                            break;
                        }
                    case 3:
                        {
                            result = tretyaproga();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Спасибо!");
                            Environment.Exit(0);
                            break;
                        }
                }
                Console.WriteLine("Нажми Enter для выбора других функций", result);
                Console.ReadKey();
            }

        }
        public static int pervayaproga()
        {

            Random random = new Random();
            int winner = random.Next(0, 100);
            bool win = false;
            do
            {
            
                Console.WriteLine("Угадай число в интервале от 0 до 100: ");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                if (i > winner)
                {
                    Console.WriteLine("Твое число меньше!");
                }
                else if (i < winner)
                {
                    Console.WriteLine("Твое число больше!");
                }
                else if (i == winner)
                {
                    Console.WriteLine("Поздравляю, ты угадал!");
                    win = true;
                }
            } while (win == false);
            int result = 1;
            return result;
        }
        public static int vtorayaproga()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            } 
            int result = 1;
            return result;
        }
        public static int tretyaproga()
        {
            Console.WriteLine("Введи число");
            int p = int.Parse(Console.ReadLine());
            for (int a = 1; a <= p; a++)
            {
                if (p % a == 0)
                    Console.Write(a + " ");
            }
            Console.WriteLine();
            int result = 1;
            return result;
        }
    }
}