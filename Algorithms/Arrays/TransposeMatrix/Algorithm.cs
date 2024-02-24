using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.TransposeMatrix
{
    public static class Algorithm
    {
        public static int[][] Run(int[][] matrix)
        {
            if(matrix != null)
            {
                var result = new int[matrix[0].Length][];

                for(var i = 0; i < matrix.GetLength(0); i++)
                {
                    result[i] = new int[matrix.GetLength(0)];
                    for(var j = 0; j < matrix[i].Length; j++)
                    {
                        result[j][i] = matrix[i][j];
                    }
                }

                return result;
            }

            return null;
        }
    }
}
