namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            while (true)
            {
                bool end = true;
                for (int j = 3; j <= 19; j++)
                {
                    if (number % j != 0)
                    {
                        end = false;
                        break;
                    }
                }
                if (end)
                {
                    break;
                }
                number += 20;
            }
            Console.WriteLine(number);
        }
    }
}
