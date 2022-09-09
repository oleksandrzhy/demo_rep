using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int number = 0;
            int[] frequency = new int[10];
            while (number > 0)
            {
                int d = number % 10;
                frequency[d]++;
                number /= 10;
                Array.Sort(frequency);
                foreach (var item in frequency)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
