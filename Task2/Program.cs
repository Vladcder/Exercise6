using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine().Replace(" ", "");
            bool isPalindrome = true;
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length-1-i])
                {
                    isPalindrome=false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
