// O(n*n) 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abqbba";
            System.Console.WriteLine(LongestPalindraomeString(str));
        }

        public static string LongestPalindraomeString(string str)
        {
            var longest = str.Substring(0, 1);
            for (int i = 0; i < str.Length - 1; i++)
            {
                var s1 = ExpandAroundCenter(str, i, i);
                if (s1.Length > longest.Length)
                {
                    longest = s1;
                }
                var s2 = ExpandAroundCenter(str, i, i + 1); // string like "abba" their center is in middle of two b's
                if (s2.Length > longest.Length)
                {
                    longest = s2;
                }
            }
            return longest;
        }

        public static string ExpandAroundCenter(string str, int left, int right)
        {
            while (left >= 0 && right <= str.Length && str[left] == str[right])
            {
                left--;
                right++;
            }
            return str.Substring(left + 1, right - left - 1);  // since after this loop left has decremeted one extra nd right has incremented on extra.
        }
    }

}
