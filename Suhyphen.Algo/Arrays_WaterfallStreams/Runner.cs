using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Arrays_WaterfallStreams
{
    internal class Runner
    {
        public static void Run()
        {
            //This should return { 0, 0, 0, 25, 25, 0, 0}
            double[][] array = new double[7][];
            array[0] = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            array[1] = new double[] { 1, 0, 0, 0, 0, 0, 0 };
            array[2] = new double[] { 0, 0, 1, 1, 1, 0, 0 };
            array[3] = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            array[4] = new double[] { 1, 1, 1, 0, 0, 1, 0 };
            array[5] = new double[] { 0, 0, 0, 0, 0, 0, 1 };
            array[6] = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            int source = 3;
            double[] result = Algorithm.WaterfallStreams(array, source);
            Console.WriteLine("[{0}]", string.Join(", ", result));

            //This should return [0, 0, 100, 0, 0, 0, 0]
            double[][] array2 = new double[2][];
            array2[0] = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            array2[1] = new double[] { 1, 0, 0, 0, 0, 0, 0 };
            source = 2;
            result = Algorithm.WaterfallStreams(array2, source);
            Console.WriteLine("[{0}]", string.Join(", ", result));

            //This should return [0, 0, 100, 0, 0, 0, 0]
            double[][] array3 = new double[1][];
            array3[0] = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            source = 2;
            result = Algorithm.WaterfallStreams(array3, source);
            Console.WriteLine("[{0}]", string.Join(", ", result));

            //This should return { 0, 0, 0, 37.5, 0, 0, 0}
            double[][] array4 = new double[7][];
            array4[0] = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            array4[1] = new double[] { 1, 0, 0, 0, 0, 0, 0 };
            array4[2] = new double[] { 0, 0, 1, 1, 1, 0, 0 };
            array4[3] = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            array4[4] = new double[] { 1, 1, 1, 0, 0, 1, 0 };
            array4[5] = new double[] { 0, 0, 0, 0, 1, 0, 1 };
            array4[6] = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            source = 3;
            result = Algorithm.WaterfallStreams(array4, source);
            Console.WriteLine("[{0}]", string.Join(", ", result));

        }
    }
}
