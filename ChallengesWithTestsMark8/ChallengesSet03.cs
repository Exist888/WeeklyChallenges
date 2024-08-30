using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
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
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)     //Note to self, source: https://stackoverflow.com/questions/20032450/detect-if-a-string-contains-uppercase-characters
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)     //Note to self, source: https://stackoverflow.com/questions/29838618/c-how-to-get-first-character-of-a-string
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)     //Note to self, see above
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()     //Note to self, sources: https://stackoverflow.com/questions/21539117/c-sharp-variable-or-array-with-number-range-example-1-100
        {                                                                   //https://stackoverflow.com/questions/724501/how-to-assign-array-values-at-run-time
            var intArray = Enumerable.Range(1, 100).ToArray();
            var intList = new List<int>();

            foreach (int intItem in intArray)
            {
                if (intItem % 2 != 0)
                {
                    intList.Add(intItem);
                }
            }
            int[] intArray2 = intList.ToArray();
            return intArray2;
        }
        
        //ATTN: :) 
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            // foreach (string word in words)
            // {
            //     word.ToUpper();
            // }
        }
    }
}
