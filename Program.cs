using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCeeSharpCalculator_Polish
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Simple Cee Sharp Calculator - POLSKI";

            Console.Clear();
            Thread.Sleep(100);

            Console.Title = title;

            Console.Write(title);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Proszę wybrać typ operacji:");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1 - SUMA (+)");
            Console.WriteLine("2 - RÓŻNICA (-)");
            Console.WriteLine("3 - ILOCZYN (*)");
            Console.WriteLine("4 - ILORAZ (/)");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Dodatkowe operacje:");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("5 - POTĘGOWANIE");
            Console.WriteLine("6 - PIERWIASTKOWANIE");
            Console.WriteLine("7 - OBLICZANIE LICZBY Z PROCENTÓW");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("> "); string string_typed_op = Console.ReadLine();

            int typed_op = int.Parse(string_typed_op);

            Console.Clear();

            switch(typed_op)
            {
                case 1:
                    {
                        Console.Write("Podaj pierwszą liczbę:");
                        Console.WriteLine();

                        string s_num1 = Console.ReadLine();

                        float num1 = float.Parse(s_num1);

                        Console.Clear();

                        Console.Write("Podaj drugą liczbę:");
                        Console.WriteLine();

                        string s_num2 = Console.ReadLine();

                        float num2 = float.Parse(s_num2);

                        Console.Clear();

                        Console.Write("Wynik: "); Console.Write(num1 + num2);

                        Console.WriteLine();
                        Console.Write("Naciśnij byle jaki klawisz, aby kontynuować!");

                        Console.ReadKey();

                        Main(null);

                        break;
                    }
                case 2:
                    {
                        Console.Write("Podaj pierwszą liczbę:");
                        Console.WriteLine();

                        string s_num1 = Console.ReadLine();

                        float num1 = float.Parse(s_num1);

                        Console.Clear();

                        Console.Write("Podaj drugą liczbę:");
                        Console.WriteLine();

                        string s_num2 = Console.ReadLine();

                        float num2 = float.Parse(s_num2);

                        Console.Clear();

                        Console.Write("Wynik: "); Console.Write(num1 - num2);

                        Console.WriteLine();
                        Console.Write("Naciśnij byle jaki klawisz, aby kontynuować!");

                        Console.ReadKey();

                        Main(null);

                        break;
                    }
                case 3:
                    {
                        Console.Write("Podaj pierwszą liczbę:");
                        Console.WriteLine();

                        string s_num1 = Console.ReadLine();

                        float num1 = float.Parse(s_num1);

                        Console.Clear();

                        Console.Write("Podaj drugą liczbę:");
                        Console.WriteLine();

                        string s_num2 = Console.ReadLine();

                        float num2 = float.Parse(s_num2);

                        Console.Clear();

                        Console.Write("Wynik: "); Console.Write(num1 * num2);

                        Console.WriteLine();
                        Console.Write("Naciśnij byle jaki klawisz, aby kontynuować!");

                        Console.ReadKey();

                        Main(null);

                        break;
                    }
                case 4:
                    {
                        Console.Write("Podaj pierwszą liczbę:");
                        Console.WriteLine();

                        string s_num1 = Console.ReadLine();

                        float num1 = float.Parse(s_num1);

                        Console.Clear();

                        Console.Write("Podaj drugą liczbę:");
                        Console.WriteLine();

                        string s_num2 = Console.ReadLine();

                        float num2 = float.Parse(s_num2);

                        Console.Clear();

                        Console.Write("Wynik: "); Console.Write(num1 / num2);

                        Console.WriteLine();
                        Console.Write("Naciśnij byle jaki klawisz, aby kontynuować!");

                        Console.ReadKey();

                        Main(null);

                        break;
                    }
                case 5:
                    {
                        Console.Write("Podaj liczbę:");
                        Console.WriteLine();

                        string s_num1 = Console.ReadLine();

                        float num1 = float.Parse(s_num1);

                        Console.Clear();

                        Console.Write("Podaj ile do potęgi:");
                        Console.WriteLine();

                        string s_pow = Console.ReadLine();

                        float power = float.Parse(s_pow);

                        Console.Clear();

                        Console.Write("Wynik: "); Console.Write(Math.Pow(num1, power));

                        Console.WriteLine();
                        Console.Write("Naciśnij byle jaki klawisz, aby kontynuować!");

                        Console.ReadKey();

                        Main(null);

                        break;
                    }
                case 6:
                    {
                        Console.Write("Podaj liczbę:");
                        Console.WriteLine();

                        string s_num1 = Console.ReadLine();

                        float num1 = float.Parse(s_num1);

                        Console.Clear();

                        Console.Write("Podaj stopień:");
                        Console.WriteLine();

                        string s_step = Console.ReadLine();

                        float step = float.Parse(s_step);

                        Console.Clear();

                        Console.Write("Wynik: "); Console.Write(Math.Pow(num1, 1 / step));

                        Console.WriteLine();
                        Console.Write("Naciśnij byle jaki klawisz, aby kontynuować!");

                        Console.ReadKey();

                        Main(null);

                        break;
                    }
                case 7:
                    {
                        Console.Write("Podaj liczbę:");
                        Console.WriteLine();

                        string s_num1 = Console.ReadLine();

                        float num1 = float.Parse(s_num1);

                        Console.Clear();

                        Console.Write("Podaj procent:");
                        Console.WriteLine();

                        string s_percent = Console.ReadLine();

                        float percent = float.Parse(s_percent);

                        Console.Clear();

                        Console.Write("Wynik: "); Console.Write(num1 * percent * 0.01);

                        Console.WriteLine();
                        Console.Write("Naciśnij byle jaki klawisz, aby kontynuować!");

                        Console.ReadKey();

                        Main(null);

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Podałeś niepoprawną operację!");
                        Console.WriteLine("Naciśnij byle jaki klawisz, aby kontynuować!");

                        Console.ReadKey();

                        Main(null);

                        break;
                    }
            }
        }
    }
}
