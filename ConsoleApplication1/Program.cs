using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            askNumber("For start enter 1:", 1, 1);


            int number1 = askNumber("Please enter number 1 frome 1 to 10:", 1, 10);

            int number2 = askNumber("Please enter number 2 frome 1 to 10:", 1, 10);

            int result = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, result);
            Console.WriteLine("For exit press Enter....");
            Console.ReadLine();


        }

        public static int askNumber(string messages, int from, int to)
        {
            bool point = true;
            while (point)
            {
                Console.WriteLine(messages);
                int result = parseInt(Console.ReadLine());

                if (checkNumber(result, from, to))
                {
                    return result;
                }
            }
            throw new Exception("Failed askNumber();");
        }

        public static bool checkNumber(int number, int from, int to)
        {
            return number >= from && number <= to;
        }

        public static Int32 parseInt(string number)
        {
            int result;
            if (Int32.TryParse(number, out result))
            {
                return result;
            }
            else
            {
                return -1;
            }
        }

    }
}
