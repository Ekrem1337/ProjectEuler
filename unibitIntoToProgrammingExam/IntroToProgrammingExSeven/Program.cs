namespace IntroToProgrammingExSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int primeNumberCount = 1;
            while (primeNumberCount!=10001)
            {
                number++;
                if (number % 2 == 0)
                {
                    continue;
                }

                bool isPrime = true;
                for (int i = 3; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumberCount++;
                }

            }
            Console.WriteLine(number);
        }
    }
}
