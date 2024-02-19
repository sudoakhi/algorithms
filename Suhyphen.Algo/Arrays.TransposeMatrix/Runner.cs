using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Arrays.TransposeMatrix
{
    internal static class Runner
    {
        public static void Run()
        {
			var matrix = new int[1][];
			matrix[0] = new int [1];
			matrix [0][0] = 1;
			matrix [0][0] = 2;
			var resultMatrix = Algorithm.TransposeMatrix(matrix);
            for(var i=0; i< resultMatrix.GetLength(0); i++)
            {
                for(var j=0; j< resultMatrix.GetLength(1); j++)
                {
                    Console.WriteLine(resultMatrix[i][j]);
                }
            }
        }
    }
}
