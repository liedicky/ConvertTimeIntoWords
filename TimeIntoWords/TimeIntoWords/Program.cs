using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeIntoWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable
            bool loop = true;
            int h, m;

            // Keep looping if it does not reach the end of the loop
            while (loop)
            {
                try
                {
                    // Retrieve and convert the input into integer (if it gives wrong time format, throw an exception)
                    Console.Write("Input the hour: ");
                    h = Convert.ToInt32(Console.ReadLine());
                    if (h > 12)
                    {
                        throw new InvalidTimeFormatException();
                    }
                    Console.Write("Input the minute: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    if (m > 59)
                    {
                        throw new InvalidTimeFormatException(h, m);
                    }

                    // Write the output
                    Console.Write("Output: ");
                    Console.WriteLine(BusinessLogic.timeInWords(h, m));

                    // Break the loop
                    loop = false;

                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Wrong input format");
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured");
                }
            }
        }
    }
}
