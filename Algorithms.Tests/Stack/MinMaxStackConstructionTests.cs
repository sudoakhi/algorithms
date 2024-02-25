// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Stack.MinMaxStackConstruction;

namespace Algorithms.Tests.Stack
{
    [TestClass]
    public class MinMaxStackConstructionTests
    {
        [TestMethod]
        public void TestCase1()
        {
            Algorithm.Push(5);
            Assert.AreEqual(5, Algorithm.Peek( ));
            Assert.AreEqual(5, Algorithm.CurrentMinimum( ));
            Assert.AreEqual(5, Algorithm.CurrentMaximum( ));
            Algorithm.Push(7);
            Assert.AreEqual(7, Algorithm.Peek( ));
            Assert.AreEqual(5, Algorithm.CurrentMinimum( ));
            Assert.AreEqual(7, Algorithm.CurrentMaximum( ));
            Algorithm.Push(2);
            Assert.AreEqual(2, Algorithm.Peek( ));
            Assert.AreEqual(2, Algorithm.CurrentMinimum( ));
            Assert.AreEqual(7, Algorithm.CurrentMaximum( ));
            _ = Algorithm.Pop( );
            Assert.AreEqual(7, Algorithm.Peek( ));
            Assert.AreEqual(5, Algorithm.CurrentMinimum( ));
            Assert.AreEqual(7, Algorithm.CurrentMaximum( ));
            _ = Algorithm.Pop( );
            Assert.AreEqual(5, Algorithm.Peek( ));
            Assert.AreEqual(5, Algorithm.CurrentMinimum( ));
            Assert.AreEqual(5, Algorithm.CurrentMaximum( ));
        }
    }
}
