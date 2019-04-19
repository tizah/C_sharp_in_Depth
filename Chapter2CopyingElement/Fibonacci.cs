using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2CopyingElement
{
    public class Fibonacci
    {
        public static IEnumerable<int> FibonacciSeries(int len)
        {
            int a = 0, b = 1, c = 0;
            List<int> series = new List<int>();
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
                series.Add(c);
            }
        
            return series;
        }
    }
}
