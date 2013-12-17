using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Мини задание в закрепление темы: найди 3 (или то колво которое укажет пользователь) наименьших элемента в случайном массиве
[0:28:21] Артем Колосович : Завтра скину еще задание*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie2();
        }
        static void Zadanie1()
        {
            int Dlina = 0;
            string Nachalo;
            Console.Write("Введите значение длины массива: ");
            Nachalo = Console.ReadLine();
            if (int.TryParse(Nachalo, out Dlina))
            {
                Massiv mas = new Massiv();
                mas.Mas(Dlina);



                Console.WriteLine();
                Console.ReadLine();
            }
        }

        static void Zadanie2()
        {
            int Dlina = 0;
            string Nachalo;
            Console.Write("Введите значение : ");
            Nachalo = Console.ReadLine();
            if (int.TryParse(Nachalo, out Dlina))
            {
                Massiv2 mas = new Massiv2();
                mas.Mas(Dlina);



                Console.WriteLine();
                Console.ReadLine();

            }
        }
        class Massiv2
        {
            public void Mas(int Dl)
            {
                int[,] massiv = new int[Dl, Dl];

                CreateMassiv(massiv, Dl);

            }
            void CreateMassiv(int[,] m, int g)
            {
                Random rnd = new Random();
                for (int i = 0; i < g; i++)
                    for (int j = 0; j < g; j++)
                    {
                        m[i, j] = rnd.Next(0, 99);
                    }

                Console.WriteLine();
                Console.WriteLine("Массив");
                for (int i = 0; i < g; i++)
                {
                    for (int j = 0; j < g; j++)
                        Console.Write(m[i, j] + "     ");
                    Console.WriteLine();
                }

                Sort(m, g);

            }
            public void Sort(int[,] mm, int gg)
            {
                bool Uslovie = true;
                while (Uslovie)
                {
                    Uslovie = false;
                    int[] Pomosh = new int[gg];
                    for (int i = 0; i < gg - 1; i++)
                        for (int j = 0; j < gg - 1; j++)
                            if (mm[i, j] > mm[i + 1, j + 1])
                            {
                                for (int h = 0; h < gg; h++)
                                {
                                    Pomosh[h] = mm[h, j];
                                    mm[h, j] = mm[h, j + 1];
                                    mm[h, j + 1] = Pomosh[h];
                                    Uslovie = true;
                                }
                            }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Массив после сортировки");
                for (int i = 0; i < gg; i++)
                {
                    for (int j = 0; j < gg; j++)
                        Console.Write(mm[i, j] + "     ");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
        class Massiv
        {

            public void Mas(int Dl)
            {
                int[] massiv = new int[Dl];

                CreateMassiv(massiv);

            }
            void CreateMassiv(int[] m)
            {
                Random rnd = new Random();
                for (int i = 0; i < m.Length; i++)
                {
                    m[i] = rnd.Next(0, 99);
                }
                Console.WriteLine();
                Console.WriteLine("Массив");
                for (int i = 0; i < m.Length; i++)
                    Console.Write(m[i] + "     ");
                Sort(m);
            }
            public void Sort(int[] mm)
            {
                bool Uslovie = true;
                while (Uslovie)
                {
                    Uslovie = false;
                    int a = 0;
                    for (int i = 0; i < mm.Length - 1; i++)
                        if (mm[i] > mm[i + 1])
                        {
                            a = mm[i];
                            mm[i] = mm[i + 1];
                            mm[i + 1] = a;
                            Uslovie = true;
                        }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Массив после сортировки");
                for (int i = 0; i < mm.Length; i++)
                    Console.Write(mm[i] + "     ");
            }


        }
    }
}
