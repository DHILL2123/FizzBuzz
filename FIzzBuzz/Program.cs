using System;
using System.Collections.Generic;
using System.Linq;



namespace FizzBuzz
{
    public class FizzBuzzTest
    {
        static void Main(string[] args)
        {
            FizzBuzz(20);
        }


        public static void FizzBuzz(int num)
        {
            for (int i = 1; i < 21; i++)
            {
                string result = "";

                if (i % 3 == 0)
                    result += "Fizz";

                if (i % 5 == 0)
                    result += "Buzz";

                if (result == "")
                    result = i.ToString();


                Console.WriteLine($"{result}");

            }

        }


    }   }
    