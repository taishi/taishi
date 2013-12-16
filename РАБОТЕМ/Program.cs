using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Test2();
        }
        static void Test1()
        {
            int g = 0;
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
                int[,] mas = new int[g, g];
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
                            if (j < (g - 1))
                                mas2[i, j] = mas[i, (j + 1)];
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
        static void Test2()
        {
            int i;
            string p;
            Console.Write("Введите число: ");
            p = Console.ReadLine();
            if (int.TryParse(p, out i))
            {
                int [] mass = new int [i];
                Random rnd = new Random();
                Console.WriteLine();
                for (int j = 0; j < i; j++)
                {
                    mass[j] = rnd.Next(0, 99);
                    Console.Write(mass[j] + "    ");
                }
                Math math = new Math();
                math.Sort1(mass);

                Console.WriteLine();
                Console.WriteLine();

                for (int j = 0; j < i; j++)
                {
                    Console.Write(mass[j] + "    ");
                }
                Console.ReadLine();
            }
        }
    }
    class Math
    {
        public void Sort1(int[] g)
        {
            Array.Sort(g);
        }
    }
   
}
