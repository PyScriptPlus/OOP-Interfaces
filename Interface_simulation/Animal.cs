using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_simulation
{
    internal class Animal : IAnimal
    {
        public override void dogAdjective(int age, string name, myColor color)
        {
            Console.WriteLine(" Dog traits: ");
            Console.WriteLine(
                $"Dog name is: ({name})" +
                $" And age is: ({age})" + 
                $" And color is: ({color})");
            return;
        }
    }
}
