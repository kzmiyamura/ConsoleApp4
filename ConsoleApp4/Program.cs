using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2つの数字を入力して足し算します。");

            int x = ReadIntFromConsole("1つ目の数字を入力してください:");
            int y = ReadIntFromConsole("2つ目の数字を入力してください:");

            Calculator calc = new Calculator();
            int sum = calc.Add(x, y);

            Console.WriteLine($"結果: {x} + {y} = {sum}");
        }

        // 入力チェック付きメソッド
        static int ReadIntFromConsole(string message)
        {
            int result;
            string? input;

            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();

                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine("数字を正しく入力してください。");
                }
            } while (!int.TryParse(input, out result));

            return result;
        }
    }
}
