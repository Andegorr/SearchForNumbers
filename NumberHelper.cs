using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SearchForNumbers1
{
    public class NumberHelper
    {
        public static List<int> FindNumbers(string inputText)
        {
            List<int> numbers = new List<int>();

            string pattern = @"\b\d+\b"; // Регулярное выражение для поиска чисел
            MatchCollection matches = Regex.Matches(inputText, pattern);

            foreach (Match match in matches)
            {
                numbers.Add(int.Parse(match.Value));
            }

            return numbers;
        }
    }
}
