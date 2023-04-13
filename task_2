

using System;

class HelloWorld
{
    static void Main()
    {
        int a, b, c;
        Console.Write("Введите коэфициент A: ");
        string st = Console.ReadLine();
        a = Convert.ToInt32(st);
        Console.Write("Введите коэфициент B: ");
        st = Console.ReadLine();
        b = Convert.ToInt32(st);
        Console.Write("Введите коэфициент C: ");
        st = Console.ReadLine();
        c = Convert.ToInt32(st);
        Solution(a, b, c);
    }
    static void Solution(int a, int b, int c)
    {
        double d = b * b - 4 * a * c;
        if (d > 0)
        {
           Console.WriteLine("Уравнение вида {0}x^2 + ({1}) + {2} = 0, имеет 2 решения {3} и {4}", a, b, c,  (-b + Math.Sqrt(d)) / (2 * a),  (-b - Math.Sqrt(d)) / (2 * a)); 
        }
        else if (d == 0)
        {
            Console.WriteLine("Уравнение вида {0}x^2 + ({1}) + {2} = 0, имеет 1 решения {3}", a, b, c,  -b / (2 * a));    
        }
        else
        {
            Console.WriteLine("Иди нахуй!");
        }
    }
}
