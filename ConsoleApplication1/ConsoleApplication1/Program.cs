namespace MainSolution
{
    class Program
    {
        public static void Print(int n)
        {
            string str = "1";
            for (int i = 1; i < n; i++)
            {
                str = CountAndSay(str);
            }
        }

        public static string CountAndSay(string s)
        {
            string ans = "";
            int cnt = 1;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (i + 1 < len && s[i] != s[i + 1])
                {
                    ans = ans + cnt.ToString() + s[i];
                    cnt = 1;
                }
                else if (i + 1 < len)
                {
                    cnt++;
                }
            }
            ans = ans + cnt.ToString() + s[len - 1]; // for the last similar elements we need this. do a dry run on 1211 and you will understand becasue at the end
            // we will only have the count we need to append to the element too that is why below line. 
            return ans;
        }
        static void Main(string[] args)
        {
            Print(36);
        }
    }
}
