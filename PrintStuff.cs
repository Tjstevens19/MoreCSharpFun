using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        private string language;

        //Constructor
        public PrintStuff() 
        {
            language = "EN";
        }
        public PrintStuff(string temp) 
        {
            language = temp;
        }

        public void PrintName(string firstName)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + firstName + "!");
            }
            
            if (language == "SP")
            {
                System.Console.WriteLine("Hola, " + firstName + "!");
            }
        }
        // You can overload by naming a second method the same thing, one happens if you pass something in,
        // the other happens if you don't pass anything in
        public void PrintName()
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, John or Jane Doe!");
            }

            if (language == "SP")
            {
                System.Console.WriteLine("Hola, Juan o Jane Doe!");
            }
        }

        //Or you could do this way and have the method return something.
        //public static string PrintName(string firstName)
        //{
        //    string output = "";

        //    output = "Hello, " + firstName + "!";

        //    return output;
        //}
    }
}
