using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge_110221
{
    public class Fractions
    {
        //1) Create a function double UniqueFract(),
        //which should sum all irreducible regular fractions between 0 and 1,
        //in the numerator and denominator of which there are only single-digit numbers:
        //1/2, 1/3, 1/4, ... 2/3, 2/4, ... 8/9.

        //Notes:
        //-Of the fractions 1/2 2/4 3/6 4/8, only 1/2 is included in the sum.
        //-Don't include any values >= 1.
        //-Both the numerator and denominator are single digit.

        public static double UniqueFract()
        {
            //for i = 1 to 9
            //    for j = 1 to 9
            //     frac = i / j
            //        if (frac >= 1) // don't add it
            //            if (isReducible(frac)) // don't add it
            //                sum += frac

            double result = 0;

            for(int demonimator = 2; demonimator <= 9; demonimator++)
            {
                for (int numerator = 1; numerator < demonimator; numerator++)
                {
                
               
                    string startingFraction = $"{numerator}/{demonimator}";
                    if(SimplifyFraction(startingFraction) == true)
                    {
                        result += (double)numerator / (double)demonimator;
                    }


                }

            }
            return result;
        }

        public static string AddFractionAsString(string fraction, string fraction2)
        {
            string[] numbers = fraction.Split("/");
            int num = Convert.ToInt32(numbers[0]);
            int den = Convert.ToInt32(numbers[1]);

            return fraction;
        }

        public static bool SimplifyFraction(string fraction)
        {
            //Dictionary<string, bool> fractionDictionary = new Dictionary<string, bool>();
            bool boolResult = false;
            string result = "";
            //split the fraction at the / and save numbers in integer variable 
            string[] numbers = fraction.Split("/");
            int num = Convert.ToInt32(numbers[0]);
            int den = Convert.ToInt32(numbers[1]);
            //check if denominator is 1 ***also check after simplifying***
            if (den == 1)
            {
                //fractionDictionary.Add(num.ToString(), false);
                return false;
            }
            //check if numbers can be simplified by getting GCD
            int a = num;
            int b = den;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            //Get new fraction by dividing original number by the GCD
            int newA = num / a;
            int newB = den / a;
            if (newB == 1)
            {
                //fractionDictionary.Add(newA.ToString(), false);
                return false;
            }
            //check if solution is equal to input fraction
            result = $"{newA}/{newB}";
            if (result.Equals(fraction))
            {
                //fractionDictionary.Add(result, true);
                boolResult = true;
            }
            else
            {
                //fractionDictionary.Add(result, false);
                boolResult = false;
            }

            //return result
            return boolResult;
        }
    }
}
