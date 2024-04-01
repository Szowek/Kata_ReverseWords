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
            return "";
        }
    }
}
