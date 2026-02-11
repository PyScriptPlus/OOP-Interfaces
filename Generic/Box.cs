using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Box<T>
    {
        public T? value;
        public T foo(T msg) => msg;
    }
}
