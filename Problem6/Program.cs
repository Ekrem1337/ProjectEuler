namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                sum += i;
            }
            sum *= sum;

            Console.WriteLine(sum - sumOfSquares);
        }
    }
}
