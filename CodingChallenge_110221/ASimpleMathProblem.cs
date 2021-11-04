using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge_110221
{
    class ASimpleMathProblem
    {
        //2) Consider the following operation on an arbitrary positive integer:

        //- If n is even -> n / 2
        //- If n is odd -> n* 3 + 1

        //Create a function to repeatedly evaluate these operations, until reaching 1. Return the number of steps it took.
        int count = 0;
        public int SimpleMethod(int n)
        {
            count++;
            if (n % 2 == 0)
                n = n / 2;
            else
                n = (n * 3) + 1;

            if (n != 1)
                SimpleMethod(n);


            return count;
        }
    }
}
