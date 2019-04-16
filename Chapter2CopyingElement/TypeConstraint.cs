using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2CopyingElement
{
    public class TypeConstraint
    {
        static void PrintItems<T>(List<T> items) where T : IFormattable
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            foreach (T item in items)
            {
                Console.WriteLine(item.ToString(null, culture));
            }
        }
    }
}
