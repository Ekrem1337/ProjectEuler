namespace IntroToProgrammingExEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 500; a++)
            {
                for (int b = 1; b < 500; b++)
                {
                    double c = Math.Sqrt((a * a) + (b * b));
                    if (a + b + c == 1000)
                    {
                        Console.WriteLine($"a={a}; b={b}; c={c:f2}");
                    }
                }
            }
        }
    }
}
