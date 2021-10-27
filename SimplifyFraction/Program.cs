using System;

namespace SimplifyFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Run("4/8")); 
            Console.WriteLine(Run("4/6")); 
            Console.WriteLine(Run("10/11")); 
            Console.WriteLine(Run("100/400")); 
            Console.WriteLine(Run("8/4")); 
        }
        //Takes in fraction as string and returns simplified version as a string
        private static string Run(string fraction)
        {
            
            string result = "";
            //split the fraction at the / and save numbers in integer variable 
            string[] numbers = fraction.Split("/");
            int num = Convert.ToInt32(numbers[0]);
            int den = Convert.ToInt32(numbers[1]);
            //check if denominator is 1 ***also check after simplifying***
            if(den == 1)
            {
                return num.ToString();
            }
            //check if numbers can be simplified
            int a = num;
            int b = den;
            while(a != b)
            {
                if(a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            int newA = num / a ;
            int newB = den / a;
            if (newB == 1)
                return newA.ToString();

            result = $"{newA}/{newB}";



            //return result
            return result;
        }
    }
}
