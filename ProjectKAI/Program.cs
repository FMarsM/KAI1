using System;

namespace ProjectKAI
{
    class Program
    {
        static string EnterName()
        {
            Console.WriteLine("Напишите как вас зовут.");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет,{name}");
            return name;
        }
        static void QuadEq(string name)
        {
            if (name == null)
            {
                name = "Пользователь";
            }
            Console.WriteLine($"{name}, введите коэффициенты a, b и c квадратного уравнения.");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (Math.Sqrt(b ^ 2 - 4 * a * c) >= 0)
            {
                double x1 = (-b - (Math.Sqrt(b ^ 2 - 4 * a * c))) / (2 * a);
                double x2 = (-b + (Math.Sqrt(b ^ 2 - 4 * a * c))) / (2 * a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else
                Console.WriteLine("Корней нет.");
        }
        static void TrPasc()
        {
            Console.WriteLine("Треугольник Паскаля для 10 степеней");
            int[,] nums = new int[10,10];
            nums[0, 0] = 1;
            Console.WriteLine($"{nums[0, 0]} ");
            int rows = nums.GetUpperBound(0) + 1;
            for (int i = 1; i < rows; i++)
            {
                nums[i, 0] = 1;
                Console.Write($"{nums[i, 0]} ");
                for (int j = 1; j < i+1; j++)
                {
                    nums[i, j] = nums[i - 1, j - 1] + nums[i - 1, j];
                    Console.Write($"{nums[i,j]} ");
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1.Вычислить корни квадратного уравнения.\n2.Вывести треугольник Паскаля.");
                string ch = Console.ReadLine();
                if (ch == "1")
                {
                    QuadEq(EnterName());
                }
                if (ch == "2")
                {
                    TrPasc();
                }
            }
        }
    }
}
