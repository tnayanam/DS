using System;

namespace MainSolution
{
    class Program
    {
        public static void Main()
        {
            string str = "abebdbchag";
            string pat = "abc";
            Console.WriteLine(SearchString(str, pat));
        }
        public static string SearchString(string str, string pat)
        {
            int start_index = -1;
            if (str.Length < pat.Length)
                return "not found";
            int[] str_Hash = new int[256];
            int[] str_Pat = new int[256];
            int count = 0;
            int start = 0;
            int min_len = Int32.MaxValue;
            for (int i = 0; i < pat.Length; i++)
            {
                str_Pat[pat[i]]++;
            }
            for (int j = 0; j < str.Length; j++)
            {
                str_Hash[str[j]]++;

                if (str_Hash[str[j]] <= str_Pat[str[j]] && str_Pat[str[j]] != 0)
                {
                    count++;
                }
                // here we are basically moving the start pointer as we have already found one length
                // str_Pat[str[start]] == 0 - this takes care of movement when we dont have mathcing character in the orig string so we need to continue forward
                // str_Hash[str[start]] > str_Pat[str[start]] - if this condition is true that means we can still reduce the hash entry of orig and can still
                // get the pattern so reduce the hash entry.
                if (count == pat.Length)
                {
                    while (str_Hash[str[start]] > str_Pat[str[start]] || str_Pat[str[start]] == 0)
                    { 
                        // we only need to decrement the hash if we knwo that hash entry in string is more than the pattern has entry.
                        if (str_Hash[str[start]] > str_Pat[str[start]])
                        {
                            str_Hash[str[start]]--;
                        }
                        start++;
                    }
                    int len_window = j - start + 1;
                    if (min_len > len_window)
                    {
                        min_len = len_window;
                        start_index = start;
                    }
                }
            }
            if (start_index == -1)
            {
                Console.WriteLine("No such qindow");
                return "";
            }
            return str.Substring(start_index, min_len);
        }
    }
}