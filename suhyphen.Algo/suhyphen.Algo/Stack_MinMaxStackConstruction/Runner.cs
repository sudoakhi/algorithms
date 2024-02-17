using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Stack_MinMaxStackConstruction
{
    internal class Runner
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

            Algorithm.Pop();
            //This should return 7
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.GetMin());
            //This should return 7
            Console.WriteLine(Algorithm.GetMax());

            Algorithm.Pop();
            //This should return 5
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.GetMin());
            //This should return 5
            Console.WriteLine(Algorithm.GetMax());
        }
    }
}
