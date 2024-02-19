using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Stack.MinMaxStackConstruction
{
    internal static class Runner
    {
        public static void Run()
        {
            Algorithm.Push(5);
            //This should return 5
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.GetMin());
            //This should return 5
            Console.WriteLine(Algorithm.GetMax());

            Algorithm.Push(7);
            //This should return 7
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.GetMin());
            //This should return 7
            Console.WriteLine(Algorithm.GetMax());

            Algorithm.Push(2);
            //This should return 2
            Console.WriteLine(Algorithm.Peek());
            //This should return 2
            Console.WriteLine(Algorithm.GetMin());
            //This should return 7
            Console.WriteLine(Algorithm.GetMax());

            _ = Algorithm.Pop();
            //This should return 7
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.GetMin());
            //This should return 7
            Console.WriteLine(Algorithm.GetMax());

            _ = Algorithm.Pop();
            //This should return 5
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.GetMin());
            //This should return 5
            Console.WriteLine(Algorithm.GetMax());
        }
    }
}
