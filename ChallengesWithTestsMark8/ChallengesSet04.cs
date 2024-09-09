using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evenNumList = new List<int>();
            var oddNumList = new List<int>();
            
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumList.Add(number);
                }
            }
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddNumList.Add(number);
                }
            }
            return evenNumList.Sum() - oddNumList.Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> stringList = new List<string>();
            stringList.Add(str1);
            stringList.Add(str2);
            stringList.Add(str3);
            stringList.Add(str4);

            foreach (var stringItem in stringList)
            {
                if (stringItem == null)
                {
                    return 0;
                }
            }

            List<int> stringLength = new List<int>();

            foreach (var stringItem in stringList)
            {
                stringLength.Add(stringItem.Length);
            }
            return stringLength.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int>() { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }
        
        
        //Note to self, source: https://www.wikihow.com/Determine-if-Three-Side-Lengths-Are-a-Triangle#:~:text=All%20you%20have%20to%20do,you%20will%20have%20a%20triangle.
        //Triangel Inequality Theorum - described in source above, more reliable test than a * a + b * b = c * c
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3
                && sideLength2 + sideLength3 > sideLength1
                && sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
            else
            {
                return false;
            }
            /*if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
            else if (Math.Pow(sideLength1, 2) + Math.Pow(sideLength2, 2) == Math.Pow(sideLength3, 2))
            {
                return true;
            }
            else if (Math.Pow(sideLength1, 2) + Math.Pow(sideLength3, 2) == Math.Pow(sideLength2, 2))
            {
                return true;
            }
            else if (Math.Pow(sideLength2, 2) + Math.Pow(sideLength3, 2) == Math.Pow(sideLength1, 2))
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }

        public bool IsStringANumber(string input)
        {
            var parsedSuccess = double.TryParse(input, out double number);
            if (parsedSuccess == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullElements = new List<object>();
            var notNullElements = new List<object>();

            foreach (object element in objs)
            {
                if (element == null)
                {
                    nullElements.Add(element);
                }
                else
                {
                    notNullElements.Add(element);
                }
            }

            if (nullElements.Count() > notNullElements.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            var evensList = new List<double>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)                                //Appears not necessary: Convert.ToDouble(number);
                {
                    evensList.Add(number);
                }
            }

            if (evensList.Count == 0)
            {
                return 0;
            }
            
            // foreach (int evenNum in evensList.DefaultIfEmpty())          //Note to self, source: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.defaultifempty?view=net-8.0
            // {
            //     return 0;
            // }
            
            return evensList.Average();
            //return evensList.Sum() / evensList.Count();
        }
        
        //Note to self, source: https://stackoverflow.com/questions/29027000/c-sharp-to-calculate-factorial
        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }

            return number;
        }
    }
}
