using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Markup;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int arrayLength = vals.Length;
            if (arrayLength % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
            // var min = numbers.Min();
            // var max = numbers.Max();
            // return min = max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)     //Note to self, source: https://medium.com/@teamcode20233/exploring-c-string-length-a-comprehensive-guide-d70a72b48df9#:~:text=Using%20the%20Length%20Property%20to%20Retrive%20String%20Length%20in%20C%23&text=It%20is%20a%20property%20available,of%20characters%20in%20the%20string.
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)     //Note to self, source: https://stackoverflow.com/questions/2419343/how-to-sum-up-an-array-of-integers-in-c-sharp
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)     
        {
            if (numbers == null)
            {
                return 0;
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] = 0;
                }
            }
            return numbers.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            else if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            /*if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            else if (numbers == null)
            {
                return false;
            }
            else
            {
                return false;
            }*/
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
