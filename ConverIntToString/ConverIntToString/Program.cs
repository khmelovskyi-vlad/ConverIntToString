using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverIntToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "123";
            double doubleTest = NewMethod(test);
            Console.WriteLine(doubleTest);
            Console.ReadKey();
        }

        private static double NewMethod(string text)
        {
            int convToInt;
            double conv = 0;
            for (int i = 0; i < text.Length; i++)
            {
                convToInt = text[i] - 48;
                if (convToInt >= 0 && convToInt <= 9)
                {
                    conv = conv + convToInt * Math.Pow(10, text.Length - i - 1);
                }
                else
                {
                    throw new Exception();
                }
            }
            Console.WriteLine(conv);
            return conv;
        }
    }
}
