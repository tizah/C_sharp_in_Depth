using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2CopyingElement
{
    class Program
    {
        public static List<T> CopyAtMost<T>(
        List<T> input, int maxElements)
        {
            int actualCount = Math.Min(input.Count, maxElements);
            List<T> ret = new List<T>(actualCount);
            for (int i = 0; i < actualCount; i++)
            {
                ret.Add(input[i]);
            }
            return ret;
        }
        static void Main()  
        {
            //GenericTypeOf.PrintType<int>();
            //GenericTypeOf.PrintType<string>();

            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(10);
            //numbers.Add(20);
            //List<int> firstTwo = CopyAtMost<int>(numbers, 2);
            //Console.WriteLine(firstTwo.Count);

            GenericCounter<string>.Increment();
            GenericCounter<string>.Increment();
            GenericCounter<string>.Display();
            GenericCounter<int>.Display();
            GenericCounter<int>.Increment();
            GenericCounter<int>.Display();
        }
    }
}
