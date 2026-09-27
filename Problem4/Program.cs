namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int max = -1;
            for (int i = 999; i > 99; i--)
            {
                for (int j = i; j > 99; j--)
                {
                    int number = i * j;
                    int copy = number;
                    int reversed = 0;
                    if (copy > max)
                    {
                        while (copy > 0)
                        {
                            int digit = copy % 10;
                            reversed = reversed * 10 + digit;
                            copy /= 10;
                        }
                        if (number == reversed)
                        {
                            max = reversed;
                        }
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
