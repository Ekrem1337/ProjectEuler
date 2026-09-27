using System.Reflection.PortableExecutable;

namespace Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../matrix.txt");

            int[][] matrix = [];
            matrix = lines
                .Select(line => line.Split(' ').Select(int.Parse)
                    .ToArray())
                .ToArray();


            //Search the array horizontally
            int maxHorizontally = 0;
            int[] maxSequenceHorizontally = new int[4];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length - 3; j++)
                {
                    int currentProduct = matrix[i][j] *
                        matrix[i][j + 1] *
                        matrix[i][j + 2] *
                        matrix[i][j + 3];

                    if (currentProduct > maxHorizontally)
                    {
                        maxHorizontally = currentProduct;
                        maxSequenceHorizontally = [matrix[i][j], matrix[i][j + 1], matrix[i][j + 2], matrix[i][j + 3]];
                    }
                }
            }

            //Search the array vertically
            int maxVertically = 0;
            int[] maxSequenceVert = new int[4];
            for (int i = 0; i < matrix[0].Length; i++)
            {

                for (int j = 0; j < matrix[i].Length-3; j++)
                {
                    int currentProduct = matrix[j][i] *
                        matrix[j+1][i] *
                        matrix[j+2][i] *
                        matrix[j+3][i];

                    if (currentProduct > maxVertically)
                    {
                        maxVertically = currentProduct;
                        maxSequenceVert = [matrix[j][i], matrix[j + 1][i], matrix[j + 2][i], matrix[j + 3][i]];
                    }
                }
            }

            int maxDiagonalToRight = 0;
            int[] maxSequenceDiagonalToRight = new int[4];
            for (int i = 0; i < matrix.Length - 3; i++)
            {
                for (int j = 0; j < matrix.Length - 3; j++)
                {
                    int product = matrix[i][j]*
                        matrix[i + 1][j + 1]*
                        matrix[i + 2][j + 2]*
                        matrix[i + 3][j + 3];

                    if (product > maxDiagonalToRight)
                    {
                        maxDiagonalToRight = product;
                        maxSequenceDiagonalToRight = [matrix[i][j], matrix[i + 1][j+1], matrix[i + 2][j+2], matrix[i + 3][j+3]];
                    }
                }
            }

            int maxDiagonalToLeft = 0;
            int[] maxSequenceDiagonalToLeft = new int[4];

            for (int i = 0; i < matrix.Length - 3; i++)
            {
                for (int j = matrix.Length - 1; j > 2; j--)
                {
                    int product = matrix[i][j] *
                        matrix[i + 1][j - 1] *
                        matrix[i + 2][j - 2] *
                        matrix[i + 3][j - 3];

                    if (product > maxDiagonalToLeft)
                    {
                        maxDiagonalToLeft = product;
                        maxSequenceDiagonalToLeft = [matrix[i][j], matrix[i + 1][j - 1], matrix[i + 2][j - 2], matrix[i + 3][j - 3]];
                    }
                }
            }

            Console.WriteLine(maxHorizontally);
            Console.WriteLine(string.Join(" * ", maxSequenceHorizontally));
            Console.WriteLine(maxVertically);
            Console.WriteLine(string.Join(" * ", maxSequenceVert));
            Console.WriteLine(maxDiagonalToRight);
            Console.WriteLine(string.Join(" * ", maxSequenceDiagonalToRight));
            Console.WriteLine(maxDiagonalToLeft);
            Console.WriteLine(string.Join(" * ",maxSequenceDiagonalToLeft));
        }
    }
}
