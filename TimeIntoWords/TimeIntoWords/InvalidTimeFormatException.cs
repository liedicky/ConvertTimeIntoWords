using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeIntoWords
{
    class InvalidTimeFormatException : Exception
    {
        public InvalidTimeFormatException()
        {
            Console.WriteLine("Wrong time format!");
        }
        public InvalidTimeFormatException(int h, int m)
        {
            Console.WriteLine("Wrong time format!");
            Console.WriteLine("Received input:");
            Console.WriteLine("Hour: " + h);
            Console.WriteLine("Minute: " + m);
        }
    }
}
