using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数字を1つ入力してください:");
            int x = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("もう1つ入力してください:");
            int y = int.Parse(Console.ReadLine() ?? "0");

            var calc = new Calculator();
            int result = calc.Add(x, y);

            Console.WriteLine($"結果: {result}");
        }
    }
}
