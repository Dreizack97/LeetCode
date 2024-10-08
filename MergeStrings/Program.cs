﻿using System.Text;

namespace MergeStringsApp
{
    /// <summary>
    /// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string. 
    /// Return the merged string.
    /// Example 1:
    /// Input: word1 = "abc", word2 = "pqr"
    /// Output: "apbqcr"
    /// Explanation: The merged string will be merged as so:
    /// word1:  a   b   c
    /// word2:    p   q   r
    /// merged: a p b q c r
    /// 
    /// Example 2:
    /// Input: word1 = "ab", word2 = "pqrs"
    /// Output: "apbqrs"
    /// Explanation: Notice that as word2 is longer, "rs" is appended to the end.
    /// word1:  a   b 
    /// word2:    p   q   r   s
    /// merged: a p b q   r   s
    /// 
    /// Example 3:
    /// Input: word1 = "abcd", word2 = "pq"
    /// Output: "apbqcd"
    /// Explanation: Notice that as word1 is longer, "cd" is appended to the end.
    /// word1:  a   b   c   d
    /// word2:    p   q 
    /// merged: a p b q c   d
    /// </summary>
    static class Program
    {
        public static string word1 = "ABCD";
        public static string word2 = "QWERTY";

        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int i = 0, j = 0;

            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length)
                    stringBuilder.Append(word1[i++]);

                if (j < word2.Length)
                    stringBuilder.Append(word2[j++]);
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
