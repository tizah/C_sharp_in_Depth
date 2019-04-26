using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> source = new List<dynamic>
            {
                5,
                2.75,
                TimeSpan.FromSeconds(45)
            };
            IEnumerable<dynamic> query = source
            .AsQueryable()
            .Select(x => x * 2);
        }
    }
}
