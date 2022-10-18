
using System.Diagnostics;

namespace training;

class Program
{
    static void Main()
    {
        Calc();
    }

    static void Calc()
    {
        double n1, n2;
        double res = 0;
        string zn;
        Console.WriteLine("введите первое число: ");

        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("введите второе число: ");

        n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите действие: +, -, /, *");

        zn = Console.ReadLine();

        if (zn == "+")
        {
            res += n1 + n2;
            Console.WriteLine("Результат: " + res);
        }
        else if (zn == "-")
        {
            res += n1 - n2;
            Console.WriteLine("Результат: " + res);
        }
        else if (zn == "/")
        {
            res += n1 / n2;
            Console.WriteLine("Результат: " + res);
        }
        else if (zn == "*")
        {
            res += n1 * n2;
            Console.WriteLine("Результат: " + res);
        }
    }
}

