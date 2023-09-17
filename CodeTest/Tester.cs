using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public static class Tester
    {
        /// <summary>
        /// Function that take a string and returns true if the string is a palindrome
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(string input)
        {
            string strippedInput = "";
            foreach(char c in input) 
            { 
                if (!char.IsPunctuation(c) && c != ' ')
                {
                    strippedInput += c;
                } 
            }
            
            char[] strArr = strippedInput.ToCharArray();
            Array.Reverse(strArr);
            string revStr = new string(strArr);
            return strippedInput.Equals(revStr, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Function that takes a string and returns the count of each character in the string
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>Dictionary with each character from the string as the key and the count of each charter as the value</returns>
        public static Dictionary<char, int> CharacterCount(string input)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();

            foreach (char letter in input) 
                if (output.ContainsKey(letter)) { output[letter]++; }
                else { output.Add(letter, 1); }

            return output;
        }


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetMatches(int[] input1, int[] input2)
        {
            List<int> matches = new List<int>();
            foreach (int i in input1)  
                if (input2.Contains(i)) { matches.Add(i); }

            int[] output = matches.ToArray(); 

            return output;
        }


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are not in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetDiff(int[] input1, int[] input2)
        {
            List<int> NotMatches = new List<int>();

            foreach (int i in input1)
                if (!input2.Contains(i)) { NotMatches.Add(i); }
            
            foreach (int i in input2)
                if (!input1.Contains(i)) { NotMatches.Add(i); }
          
            int[] output = NotMatches.ToArray();

            return output;
        }
    }
}
