using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        // 1) Пользователь вводит число от 5 до 10
        // 2) Создает равномерный двумерный массив с соответствующей шириной и высотой
        // 3) В каждая ячека помещаем случайное число от 0 до 99
        // 4) 

        // |9|8|7|
        // |1|2|3|
        // |4|5|6|

        // |8|7|9|
        // |2|3|1|
        // |5|6|4|
        static void Main(string[] args)
        {
            int g=0;
            string k;
            do
            {
            loop:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Для выхода из программы нажмите 'q' \nВведите число от 5 до 10: ");
                Console.ForegroundColor = ConsoleColor.White;
                k = Console.ReadLine();
                if (k == "q")
                {
                    break;
                }
                try
                {
                    g = int.Parse(k);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\aВы ввели некорректное число! \nПопробуйте еще раз.");
                    goto loop;
                }
                int [,] mas = new int [g,g];
                if (g > 4 & g < 11)
                {
                    Random rnd = new Random();

                    for (int i = 0; i < g; i++)
                        for (int j = 0; j < g; j++)
                            mas[i, j] = rnd.Next(0, 99);

                    for (int i = 0; i < g; i++)
                    {
                        for (int j = 0; j < g; j++)
                            Console.Write(mas[i, j] + "  ");
                    Console.WriteLine();
                    }
                int[,] mas2 = new int[g, g];

                for (int i = 0; i < g; i++)
                {
                    for (int j = 0; j < g; j++)
                    {
                     if (j < (g-1))
                        mas2[i, j] = mas[i, (j+1)];
                     else
                        mas2[i, j] = mas[i, 0];
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < g; i++)
                {
                    for (int j = 0; j < g; j++)
                        Console.Write(mas2[i, j] + "  ");
                    Console.WriteLine();
                }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\aВы ввели некорректное число! \nПопробуйте еще раз.");
                }
            }
            while (true);
        }

    }
   
}
