using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            int i = 0;
            foreach (char c in str)
            {
                if (c=='{')
                {
                    i++;
                }
                else if (c=='}')
                {
                    i--;
                }
                else if (i==0)
                {
                    stringBuilder.Append(c);
                }
            }
            if (i>0)
            {
                Console.WriteLine("Не хватает }");
            }
            else if (i<0)
            {
                Console.WriteLine("Не хватает {");
            }
            else
            {
                Console.WriteLine(stringBuilder.ToString().Replace("  ", " "));
            }
            Console.ReadKey();
        }
    }
}
