using System;

namespace Palindroms_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getMaxSubstrings("aababaabce", 3));
        }

        public static int getMaxSubstrings(string s, int k)
        {
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                string subString = "";
                for(int j = i; j < s.Length; j++)
                {
                    subString += s[j];
                    if (isPalindrome(subString))
                    {
                        count++;
                        break;
                    }

                }
                
               
            }
            return count;
        }

        private static bool isPalindrome(string str)
        {
            var reversed = str.ToCharArray();
            Array.Reverse(reversed);
            var s = new string(reversed);
            if (s == str)
                return true;
            return false;
        }
    }
}
