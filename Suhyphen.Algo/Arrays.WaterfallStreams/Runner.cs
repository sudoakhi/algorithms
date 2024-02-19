using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Arrays.WaterfallStreams
{
    internal static class Runner
    {
        public static void Run()
        {
            //This should return { 0, 0, 0, 25, 25, 0, 0}
            var array = new double[7][];
            array[0] = [0, 0, 0, 0, 0, 0, 0];
            array[1] = [1, 0, 0, 0, 0, 0, 0];
            array[2] = [0, 0, 1, 1, 1, 0, 0];
            array[3] = [0, 0, 0, 0, 0, 0, 0];
            array[4] = [1, 1, 1, 0, 0, 1, 0];
            array[5] = [0, 0, 0, 0, 0, 0, 1];
            array[6] = [0, 0, 0, 0, 0, 0, 0];
            var source = 3;
            var result = Algorithm.WaterfallStreams(array, source);
            Console.WriteLine(string.Join(", ", result));

            //This should return [0, 0, 100, 0, 0, 0, 0]
            var array2 = new double[2][];
            array2[0] = [0, 0, 0, 0, 0, 0, 0];
            array2[1] = [1, 0, 0, 0, 0, 0, 0];
            source = 2;
            result = Algorithm.WaterfallStreams(array2, source);
            Console.WriteLine(string.Join(", ", result));

            //This should return [0, 0, 100, 0, 0, 0, 0]
            var array3 = new double[1][];
            array3[0] = [0, 0, 0, 0, 0, 0, 0];
            source = 2;
            result = Algorithm.WaterfallStreams(array3, source);
            Console.WriteLine(string.Join(", ", result));

            //This should return { 0, 0, 0, 37.5, 0, 0, 0}
            var array4 = new double[7][];
            array4[0] = [0, 0, 0, 0, 0, 0, 0];
            array4[1] = [1, 0, 0, 0, 0, 0, 0];
            array4[2] = [0, 0, 1, 1, 1, 0, 0];
            array4[3] = [0, 0, 0, 0, 0, 0, 0];
            array4[4] = [1, 1, 1, 0, 0, 1, 0];
            array4[5] = [0, 0, 0, 0, 1, 0, 1];
            array4[6] = [0, 0, 0, 0, 0, 0, 0];
            source = 3;
            result = Algorithm.WaterfallStreams(array4, source);
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
