using System;

using System.Linq;

namespace fuzz

{

   class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine(test("FizzBuzz"));

            Console.WriteLine(test("Fizz"));

            Console.WriteLine(test("Buzz"));

            Console.WriteLine(test("Founder"));

            Console.ReadLine();

        }

       public static string test(string str)

        {

            if (str.StartsWith("F") && str.EndsWith("B"))

            {

                return "FizzBuzz";

            }

            else if (str.StartsWith("F"))

            {

                return "Fizz";

            }

            else if (str.EndsWith("B"))

            {

                return "Buzz";

            }

            else

            {

                return str;

            }

        }

    }

}
