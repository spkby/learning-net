using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";
            
            //
            inputStr = Console.ReadLine();
            //цикла для ввода 

            while((inputStr.Length>0)&&(inputStr!=null))
            {
                string[] subStr = inputStr.Split(',');//разбили на подстроки и записали в массив subStr
                for(int i=0;i<subStr.Length;i++)
                {
                    subStr[i] = subStr[i].Replace('.', ',');
                }

                Console.WriteLine("X:{0} Y:{1}", subStr[0], subStr[1]);

                inputStr = Console.ReadLine();
            }

        }
    }
}