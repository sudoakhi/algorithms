using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack.MinMaxStackConstruction
{
    internal static class Runner
    {
        internal static void Run()
        {
            Algorithm.Push(5);
            //This should return 5
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.CurrentMinimum( ));
            //This should return 5
            Console.WriteLine(Algorithm.CurrentMaximum( ));

            Algorithm.Push(7);
            //This should return 7
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.CurrentMinimum( ));
            //This should return 7
            Console.WriteLine(Algorithm.CurrentMaximum( ));

            Algorithm.Push(2);
            //This should return 2
            Console.WriteLine(Algorithm.Peek());
            //This should return 2
            Console.WriteLine(Algorithm.CurrentMinimum( ));
            //This should return 7
            Console.WriteLine(Algorithm.CurrentMaximum( ));

            _ = Algorithm.Pop();
            //This should return 7
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.CurrentMinimum( ));
            //This should return 7
            Console.WriteLine(Algorithm.CurrentMaximum( ));

            _ = Algorithm.Pop();
            //This should return 5
            Console.WriteLine(Algorithm.Peek());
            //This should return 5
            Console.WriteLine(Algorithm.CurrentMinimum( ));
            //This should return 5
            Console.WriteLine(Algorithm.CurrentMaximum( ));
        }
    }
}
