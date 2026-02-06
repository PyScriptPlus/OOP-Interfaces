using System;
using System.Collections.Generic;
using System.Text;

namespace myProject
{
    public class Student : IStudents
    {
        public void name(out string firstName, out string lastName)
        {
            firstName = "Mohammad";
            lastName = "Yousefi";
            return;
        }

        public void studentCode(long code = 0)
        {
            Random rnd = new();

            int y = 0;
            long[] myList = new long[10];
            while (y < 10)
            {
                code = rnd.Next(11);


                bool isDuplicate = false;
                for (int i = 0; i < y; i++)
                {
                    if (myList[i] == code)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    myList[y] = code;
                    Console.WriteLine("Student Code: " + code);
                    y++;
                }
            }
        }
    }
}
