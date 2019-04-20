using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2CopyingElement
{
    public class LambdaExpression
    {
       public static Action<string> action =
(string message) => Console.WriteLine("In delegate: {0}", message);
    }
}
