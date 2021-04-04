using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            return vals.Contains(false) ? true : false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var sum = numbers.Sum();
            return (sum % 2 != 0);
            //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var lowcaseCount = 0;
            var upcaseCount = 0;
            var numCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i])) lowcaseCount++;
                if (char.IsUpper(password[i])) upcaseCount++;
                if (char.IsDigit(password[i])) numCount++;
            }
            return (lowcaseCount > 0 && upcaseCount > 0 && numCount > 0) ? true : false;
            //throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
            //throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
            //throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0 : dividend / divisor;
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums[0];
            //throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
            //throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }                
            //throw new NotImplementedException();
        }
    }
}
