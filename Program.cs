using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = @"
            Цей текст містить деякі числа в дужках, наприклад: (2123), [4456], (78), [910], 
            а також інші числа: 321, 654 і текст без дужок.
        ";

        string pattern = @"\((\d+)\)|\[(\d+)\]";


        MatchCollection matches = Regex.Matches(text, pattern);

        List<int> numbersInBrackets = new List<int>();

        foreach (Match match in matches)
        {
            if (match.Groups[1].Success)
                numbersInBrackets.Add(int.Parse(match.Groups[1].Value));
            if (match.Groups[2].Success)
                numbersInBrackets.Add(int.Parse(match.Groups[2].Value));
        }

        Console.WriteLine("Числа в дужках:");
        foreach (int number in numbersInBrackets)
        {
            Console.WriteLine(number);
        }
    }
}
