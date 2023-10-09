using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the test can be either true or false
            bool isFemale = true;
            if (isFemale)
            {
                Console.WriteLine("You are female");
            }
            //can also test2 conditions with and ie && in C#, or is||
            bool isTall = false;
            if (isTall && isFemale)
            {
                Console.WriteLine("Yo are both female and tall.");

            }
            else if (!isTall && isFemale)
            {
                Console.WriteLine("You are not tall but you are female");
            }
            else {
                Console.WriteLine("You are either not tall or not a male");
                
             }
            Console.Read();

        }

    }
}
