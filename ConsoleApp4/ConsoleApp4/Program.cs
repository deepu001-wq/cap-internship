using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] samplearray1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("first matrix");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(samplearray1[i, j] + "\t");

                }
                Console.WriteLine();
            }
            int[,] samplearray2 = new int[2, 2] { { 1, 2 }, { 2, 4 } };
            Console.WriteLine("second matrix");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(samplearray2[i, j] + "\t");

                }
                Console.WriteLine();
            }
            int[,] crr1 = new int[50, 50];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    crr1[i, j] = samplearray1[i, j] + samplearray2[i, j];
            Console.Write("\nThe Addition of two matrix is : \n");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 2; j++)
                    Console.Write("{0}\t", crr1[i, j]);
            }



        }
    }
}
