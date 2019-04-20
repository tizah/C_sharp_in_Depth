using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2CopyingElement
{
    public class GenericTypeOf
    {
        public static void PrintType<T>()
        {
            Console.WriteLine("typeof(T) = {0}", typeof(T));
            Console.WriteLine("typeof(List<T>) = {0}", typeof(List<T>));
        }
        
        public static void IterateOver<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);  
            }
        }
    }
}
