using System;
using System.Collections.Generic;
using System.Text;

namespace myProject
{
    internal interface IStudents
    {
        void name(out string firstName, out string lastName);
        void studentCode(long code);
    }
}
