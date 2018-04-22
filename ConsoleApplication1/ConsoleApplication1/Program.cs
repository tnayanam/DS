public class Program
{
    public static int check(string str, string needle)
    {
        if (str == null || needle == null || needle.Length > str.Length)
            return -1;
        int j = 0;
        for (int i = 0; i < str.Length && j<needle.Length; i++)
        {
            if (str[i] == needle[j])
            {
                j++;
            }
            else
            {
                j = 0;
            }
            if (j == needle.Length)
            {
                return i - needle.Length + 1;
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        string str = "hekjkjllo";
        string needle = "ll";
        int index = check(str, needle);
        System.Console.WriteLine(index);
    }
}