using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_For_Constraint
{
    // Sakhtaresh injurie
    public class Reference_Types<T> where T : class
    {
        // Inja faghat Reference Type ha mojaz hast 
        // Mesl Object, String, Classes, ....

        public T? name1;
        public T? name2;

        public void Swap(ref T A, ref T B)
        {
            T? Temp = A;
            A = B;
            B = Temp;
            Console.WriteLine("Name1: " + A + " Name2: " + B);
        }
    }
}
