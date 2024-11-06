using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            if (ignoreCase == true)
            {
                foreach (string wrd in words)
                {
                    if (wrd == null && wrd != word)
                    {
                        return false;
                    }
                    
                    if (wrd.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                }
            }

            if (ignoreCase == false)
            {
                foreach (string wrd in words)
                {
                    if (wrd == word)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            
            if (num == 2)
            {
                return true;
            }
            
            if (num % 2 == 0)
            {
                return false;
            }
            
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }
            
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }
            
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            int maxCount = 1;
            int currentCount = 1;
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }
            
            maxCount = Math.Max(maxCount, currentCount);

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0];
            }
            
            List<double> result = new List<double>();
            
            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }
            
            return result.ToArray();
        }
    }
}
