namespace MainSolution
{
    class Program
    {
        public static float CalcPow(int x, int y)
        {
            if (y == 0)
                return 1;
            float temp;
            temp = CalcPow(x, y / 2);
            if (y % 2 == 0)
                return temp * temp;
            else
            {
                if (y > 0)
                    return x * temp * temp;
                else
                    return (temp * temp) / 2;
            }
        }
        public static void Main()
        {
            System.Console.WriteLine(CalcPow(2, 6)); // 16
        }
    }
}