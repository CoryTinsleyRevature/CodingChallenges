using System;
using System.Collections.Generic;

namespace CodingChallenge_110221
{
    class Program
    {
        //Dictionary<string, bool> Fractions = new Dictionary<string, bool>();
        static void Main(string[] args)
        {
            ASimpleMathProblem aSimpleMathProblem1 = new ASimpleMathProblem();
            ASimpleMathProblem aSimpleMathProblem2 = new ASimpleMathProblem();
            ASimpleMathProblem aSimpleMathProblem3 = new ASimpleMathProblem();
            //Console.WriteLine(Fractions.SimplifyFraction("4/8"));
            //Console.WriteLine(Fractions.SimplifyFraction("7/5"));
            //Console.WriteLine(Fractions.SimplifyFraction("10/11"));
            //Console.WriteLine(Fractions.SimplifyFraction("100/400"));
            //Console.WriteLine(Fractions.SimplifyFraction("8/4"));

            Console.WriteLine($"The answer to problem 1 is: \n{Fractions.UniqueFract()}");

            Console.WriteLine($"The answer to number 2 with input (2) is: \n{aSimpleMathProblem1.SimpleMethod(2)}");
            Console.WriteLine($"The answer to number 2 with input (3) is: \n{aSimpleMathProblem2.SimpleMethod(3)}");
            Console.WriteLine($"The answer to number 2 with input (10) is: \n{aSimpleMathProblem3.SimpleMethod(10)}");
        }

    }
}
