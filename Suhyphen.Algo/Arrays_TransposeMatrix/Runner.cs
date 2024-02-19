using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Arrays_TransposeMatrix
{
    internal class Runner
    {
        public static void Run()
        {
            int[,] matrix =
            {
                { 1, 2 }
            };
            int[,] resultMatrix = Algorithm.TransposeMatrix(matrix);
            for(int i=0; i< resultMatrix.GetLength(0); i++)
            {
                for(int j=0; j< resultMatrix.GetLength(1); j++)
                {
                    Console.WriteLine(resultMatrix[i, j]);
                }
            }
        }
    }
}
