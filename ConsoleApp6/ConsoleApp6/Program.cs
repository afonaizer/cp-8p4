using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        ////задача1

        static void Change(double a = 1, double b = 2, double c = 3)
        {
            Console.Write($"Переменна a = {a} приняла значение ");
            a = b;
            Console.Write(a);
            Console.Write($"\nПеременна b = {b} приняла значение ");
            b = c;
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c1 = double.Parse(Console.ReadLine());
            Change(a1,b1,c1);
            Console.ReadKey();
        }

        ////задача2

        //static void Sort()
        //{
        //    int[] numbers = new int[3];
        //    Console.Write("Введите первое число: ");
        //    numbers[0] = int.Parse(Console.ReadLine());
        //    Console.Write("Введите второе число: ");
        //    numbers[1] = int.Parse(Console.ReadLine());
        //    Console.Write("Введите третье число: ");
        //    numbers[2] = int.Parse(Console.ReadLine());
        //    Array.Sort(numbers);
        //    for (int i = 0; i<numbers.Length;i++)
        //    { Console.Write($"{numbers[i]}\t"); }

        //}
        //static void Main(string[] args)
        //{
        //    Sort();
        //    Console.ReadKey();
        //}

        ////задача3

        //static void Circle()
        //{
        //    Console.Write($"Введите радиус круга = ");
        //    double r = double.Parse(Console.ReadLine());
        //    double s = Math.PI * Math.Pow(r, 2);
        //    double p = 2 * r * Math.PI;
        //    Console.Write($"Площадь круга с радиусом {r} = {s:f2}\nДлина окружности круга с радиусом {r} = {p:f2}");
        //}
        //static void Main(string[] args)
        //{

        //    Circle();
        //    Console.ReadKey();
        //}

        ////задача4

        //static void Ncount()
        //{
        //    Console.Write("Введите предложение: ");
        //    string sentence1 = Console.ReadLine();
        //    Console.Write("Введите второе предложение: ");
        //    string sentence2 = Console.ReadLine();
        //    string sentences = sentence1 + sentence2;
        //    int count = 0;
        //    foreach (char a in sentences)
        //    {
        //        if (a == 'н')
        //        { count++; }
        //        if (a == 'Н')
        //        { count++; }
        //    }
        //    Console.WriteLine($"Количество символов н в слове = {count}");
        //}
        //static void Main(string[] args)
        //{
        //    Ncount();
        //    Console.ReadKey();
        //}
    }
}
