namespace Problem0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 1; i <= 781_000; i+=2)
            {
                sum += (long)i * i;
            }
            Console.WriteLine(sum);
        }
    }
}
