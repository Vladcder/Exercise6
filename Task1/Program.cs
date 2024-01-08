using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str=Console.ReadLine();
            string[] strings = str.Split();
            string max = "";
            foreach (string s in strings)
            {
                if (s.Length>max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine($"Самое длинное слово в строке: {max}");
            Console.ReadKey();
        }
    }
}
