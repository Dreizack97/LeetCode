namespace CommonDivisorString
{
    /// <summary>
    /// For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).
    /// Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
    /// Example 1:
    /// Input: str1 = "ABCABC", str2 = "ABC"
    /// Output: "ABC"
    ///
    /// Example 2:
    /// Input: str1 = "ABABAB", str2 = "ABAB"
    /// Output: "AB"
    /// 
    /// Example 3:
    /// Input: str1 = "LEET", str2 = "CODE"
    /// Output: ""
    /// </summary>
    static class Program
    {
        public static string str1 = "ABCDABCD";
        public static string str2 = "ABCD";

        static void Main(string[] args)
        {
            if (str1 + str2 != str2 + str1)
            {
                Console.WriteLine("");
            }

            int gcdLen = GCD(str1.Length, str2.Length);
            Console.WriteLine(str1.Substring(0, gcdLen));
        }

        public static int GCD(int n1, int n2)
        {
            while (n1 != 0 && n2 != 0)
            {
                if (n1 > n2)
                {
                    n1 %= n2;
                }
                else
                {
                    n2 %= n1;
                }
            }

            return n1 | n2;
        }
    }
}
