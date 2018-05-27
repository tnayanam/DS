using System.Collections.Generic;

public class Program
{

    static void Main(string[] args)
    {
        foreach (var item in SearchString("abbcddddcccaaaddcc", "ddcc"))
        {
            System.Console.Write(item + " ");
        }
        //System.Console.WriteLine(SearchString("tasnuj", "as"));
    }

    public static int[] SearchString(string str, string pat)
    {
        List<int> retVal = new List<int>();
        int M = pat.Length;
        int N = str.Length;
        int i = 0;
        int j = 0;
        int[] lps = new int[M];

        ComputeLPSArray(pat, lps);

        while (i < N)
        {
            if (pat[j] == str[i])
            {
                j++;
                i++;
            }

            if (j == M)
            {
                retVal.Add(i - j);
                j = lps[j - 1];
            }

            else if (i < N && pat[j] != str[i])
            {
                if (j != 0)
                    j = lps[j - 1];
                else
                    i = i + 1;
            }
        }

        return retVal.ToArray();
    }

    public static void ComputeLPSArray(string pat, int[] arr)
    {
        int len = arr.Length;
        int i = 0;
        int j = 1;
        while (j < len)
        {
            if (pat[i] == pat[j])
            {
                i++; // length of previous longest prefix
                arr[j] = i;
                j++;
            }
            else
            {
                if (i != 0)
                {
                    i = arr[j - 1];

                }
                {
                    arr[j] = 0;
                    j++;
                }
            }
        }
    }
}
