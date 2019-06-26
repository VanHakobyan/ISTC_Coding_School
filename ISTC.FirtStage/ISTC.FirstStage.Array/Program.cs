using System;

namespace ISTC.FirstStage.Array
{
    class Program
    {
        static void ParamsMethod(int x, params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void PrintMatrix(int[][] jagged)
        {
            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                for (int j = 0; j < jagged[i].GetLength(0); j++)
                {
                    Console.Write($"{jagged[i][j]}, ");
                }

                Console.WriteLine();
            }
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}, ");
                }

                Console.WriteLine();
            }
        }
        static void PrintArray(char[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine($"c[{i}]={c[i]}");
            }
        }
        static void Main(string[] args)
        {
            ParamsMethod(1, 5, 5);
            int[][] jagged = new int[4][];
            jagged[0] = new int[46];
            jagged[1] = new int[2];
            jagged[2] = new int[23];
            jagged[3] = new int[26];
            jagged[0][45] = Int32.MaxValue;

            jagged[3][14] = Int32.MinValue;

            PrintMatrix(jagged);
            int[,] matrix = new int[3, 3]
            {
                //0  1  2
                { 1, 5, 7 },//0
                { 5, 5, 7 },//1
                { 0, 0, 0 } //2
            };

            int sum = 0;
            var rowLength = matrix.GetLength(0);
            var columnLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if (columnLength - 1 - i == j) sum += matrix[i, j];
                }
            }

            Console.WriteLine(sum);

            //Console.WriteLine(matrix);
            //PrintMatrix(matrix);
            //string s = "Robert Kocharyany nstav";
            //char[] charArray = s.ToCharArray();

            //PrintArray(charArray);
            //int sLength = charArray.Length;
            //Console.WriteLine(sLength);

            Console.ReadKey();
        }
    }
}
