using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while (str.Length > 0)
            {
                string[] numbers = str.Split(',');

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i].Replace('.', ',');
                }
                Console.WriteLine("X: {0} Y: {1}", numbers[0], numbers[1]);
                str = Console.ReadLine();
            }
        }
    }
}
