using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_for_Class
{

    // Generic Class daghighan chiye?
    // Ya'ni classi ke DataType hayi ke dakhel hengham ta'rif class moshakhas 
    // Nemishavad.
    // Balke vaghti Instance mikonim meghdareshun moshakhas mishe
    // Bejaye inke class faghat ba int OR string kar kone betune hame DataType ha
    // Kar konad.

    // Sakhatar codesh:
    // Mikham 2 ta noe bargardunam
    public class MyClass<T,U>
    {
        public T? myValue; // Nullable
        public U? myProp { get; set; }
    }
}
