namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int sumOfEvenNumbers = 0;
            Console.WriteLine(a);
            while (b < 4_000_000)
            {
                Console.WriteLine(b);
                if (b % 2 == 0)
                {
                    sumOfEvenNumbers += b;
                }
                int nextNumber = a + b;
                a = b;
                b = nextNumber;

            }
            Console.WriteLine("The sum is: " + sumOfEvenNumbers);
        }
    }
}
