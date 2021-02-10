using System;
using System.Collections.Generic;

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
            int count = 0;
            for (var i = 0; i < vals.Length; i++)
            {

            }
            
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
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return (numbers == null) ? 0 : sum;
            //return sum;
            //return int sum = numbers.Sum();
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
