namespace IntroToProgrammingExSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            int sum = 0;
            for (int i = 1; i <=100; i++)
            {
                sumOfSquares += i * i;
                sum += i;
            }
            sum *= sum;

            //Тук не съм сигурен кой от двата резултата е желан, позитивния или негативния
            Console.WriteLine("The difference between " +
                "the sum of squares and the squared sum: "+(sumOfSquares-sum));
            Console.WriteLine("The difference is between" +
                " squared sum and the sum of squares: "+(sum-sumOfSquares));
        }
    }
}
