using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class Kata
    {
        // "this is a test" -> "test a is this"
        // 1. "this is a test" -> ["this", "is", "a", "test"] SPLIT
        // 2. ["this", "is", "a", "test"] -> ["test", "a", "is", "this"] REVERSE
        // 3. ["test", "a", "is", "this"] -> "test a is this" JOIN
        public static string Join(List<string> list, char separator)
        {
            var sb = new StringBuilder();
            var result = "";
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
                if (i != list.Count - 1)
                {
                    sb.Append(separator);
                }
            }
            result = sb.ToString();
            return result;
        }

        public static List<string> Reverse(List<string> list)
        {
            var reversedList = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                reversedList.Add(list[i]);
            }
            return reversedList;
        }

        public static List<string> Split(string input, char separator)
        {
            var result = new List<string>();
            var currentIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == separator)
                {
                    var word = input.Substring(currentIndex, i - currentIndex);
                    result.Add(word);
                    currentIndex = i + 1;
                }
                else if (i == input.Length - 1)
                {
                    var word = input.Substring(currentIndex, input.Length - currentIndex);
                    result.Add(word);
                }
            }
            return result;
        }
        public static string ReverseWords(string str)
        {
            //var splittedWords = Split(str, ' ');
            //var reversedWords = Reverse(splittedWords);
            //var result = Join(reversedWords, ' ');
            //return result;
            var splittedWords = str.Split(' ');
            var reversedWords = splittedWords.Reverse();
            var result = string.Join(' ', reversedWords);
            return result;
        }
    }
}
