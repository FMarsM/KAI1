using System;

namespace ProjectKAI
{
    class Program
    {
        string EnterName()
        {
            Console.WriteLine("Напишите как вас зовут.");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет,{name}");
            return name;
        }
        void QuadEq(string name)
        {
            Console.WriteLine($"{name}, введите коэффициенты a, b и c квадратного уравнения.");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (Math.Sqrt(b ^ 2 - 4 * a * c)! < 0)
            {
                double x1 = (-b - (Math.Sqrt(b ^ 2 - 4 * a * c))) / (2 * a);
                double x2 = (-b + (Math.Sqrt(b ^ 2 - 4 * a * c))) / (2 * a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else
                Console.WriteLine("Корней нет.");
        }
        void TrPasc()
        {
            Console.WriteLine("Треугольник Паскаля для 10 степеней");
            int[,] nums = new int[10,10];
            nums[0, 0] = 1;
            Console.WriteLine($"{nums[0, 0]} ");
            int rows = nums.GetUpperBound(0) + 1;
            int columns = nums.Length / rows;
            for (int i = 1; i < rows; i++)
            {
                nums[i, 0] = 1;
                Console.Write($"{nums[i, 0]} ");
                for (int j = 1; j < columns; j++)
                {
                    nums[i, j] = nums[i - 1, j - 1] + nums[i - 1, j];
                    Console.Write($"{nums[i,j]} ");
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            Program hz = new Program();
            string name = hz.EnterName();
            hz.QuadEq(name);
            hz.TrPasc();


        }
    }
}
