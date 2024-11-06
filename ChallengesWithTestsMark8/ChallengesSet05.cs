using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int nextNum = startNumber + 1; nextNum <= startNumber + n; nextNum++)
            {
                if (nextNum % n == 0)
                {
                    return nextNum;
                }
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0 || business.TotalRevenue == null)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int total = 0;

            if (numbers == null)
            {
                return total;
            }
            
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    total += numbers[i + 1];
                }

            }
            return total;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            
            var validWords = words
                .Select(word => word.Trim())
                .Where(word => !string.IsNullOrEmpty(word))
                .ToArray();
            
            if (validWords.Length == 0)
            {
                return "";
            }
            
            string sentence = string.Join(" ", validWords);
            
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);
            
            if (!sentence.EndsWith("."))
            {
                sentence += ".";
            }

            return sentence;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            
            int count = (elements.Count) / 4;
            
            double[] result = new double[count];
            
            for (int i = 3, j = 0; i < elements.Count; i += 4, j++)
            {
                result[j] = elements[i];
            }

            return result;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            // A HashSet to track numbers we've seen so far
            HashSet<int> seenNumbers = new HashSet<int>();
            
            foreach (int num in nums)
            {
                int complement = targetNumber - num;
                
                if (seenNumbers.Contains(complement))
                {
                    return true;
                }
                
                seenNumbers.Add(num);
            }
            
            return false;
        }
    }
}
