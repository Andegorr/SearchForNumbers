using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace SearchinGFoRNumbers
{
    internal class NumberHelper
    {
        public static List<int> ExtractNumbers(string text)
        {
            // Use a regular expression to match both positive and negative integers
            MatchCollection matches = Regex.Matches(text, @"[-+]?\d+");

            List<int> numbers = new List<int>();

            foreach (Match match in matches)
            {
                if (int.TryParse(match.Value, out int number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }
      
    }
}
