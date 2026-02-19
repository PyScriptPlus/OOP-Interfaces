using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_For_Constraint
{
    // Inja ham faghat Value Type ha mitunim benevisim
    // Mesl:
    // int, double, float, ......
    public class Value_Types<T> where T : struct
    {
        public T? num1;
        public T? num2;

        public void Swap(ref T? n1, ref T? n2)
        {
            T? Temp = n1;
            n1 = n2;
            n2 = Temp;
            Console.Write("Number1: " + n1);
            Console.WriteLine(" Number2: " + n2);
        }

    }
}
