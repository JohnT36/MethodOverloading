using System;

namespace MethodOverloading
{
    internal class Program
    {

        //Create a method named Add, that accepts two integers
        //and returns the sum of those two integers
        //Now create an overload of the Add method to
        //account for being able to add two decimals together
        //Now create an overload of the Add method
        //that returns a string and accepts 3 parameters: 2 integers and 1 boolean

        public static int Add(int a, int b)
        {
            return (a + b);
        }
        public static double Add(double a, double b)
        {
            return (a + b);
        }
       
        public static string Add(int a, int b, bool isTrue)
        {
            var sum = a + b;
            //If the boolean parameter is equal to true, the Add method will return
            //the sum of the 2 numbers plus the word “dollars” at the end of the string.
            if (isTrue == true && sum > 1)
                { return $"{sum} dollars"; }

            else if (isTrue == true && sum == 1)
                { return $"{sum} dollar"; }

            else if (isTrue == true && sum < 1)
                { return $"{sum} dollars"; }

            else 
                { return sum.ToString(); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(3, 4));
            Console.WriteLine(Add(3.4, 3.6));
            Console.WriteLine(Add(0, 1, true));
        }



    }
}