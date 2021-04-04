using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (Char.IsLetter(c)) ? true : false;          
            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //int count = 0;
            //for (var i = 0; i < vals.Length; i++)
            //{
            //    i += count;                
            //}
            return (vals.Length % 2 == 0) ? true : false;
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();

            //return numbers.Min() + numbers.Max();            
            //using System.Linq???????
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            //return (numbers == null) ? 0 : sum;
            return sum;
            //return int sum = numbers.Sum();
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int evenTotal = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenTotal += num;
                }                               
            }
            return evenTotal;
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            return true;
            //return (numbers.Sum() % 2 != 0) ? true : false;
            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var odds = 0;
            for (var i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    odds += 1;
                }
            }
            return odds;
            //throw new NotImplementedException();
        }
    }
}
