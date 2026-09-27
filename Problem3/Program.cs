namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = 600_851_475_143;
            long max = 1;
            for (long i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    max = i;
                    number /= i;
                }

            }
            Console.WriteLine(max);
        }
    }
}
