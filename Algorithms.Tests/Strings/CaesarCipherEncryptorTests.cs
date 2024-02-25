// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Strings.CaesarCipherEncryptor;

namespace Algorithms.Tests.Strings
{
    [TestClass]
    public class CaesarCipherEncryptorTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var inputString = "xyz";
            var key = 2;
            var expected = "zab";
            var actual = Algorithm.Run(inputString, key);
            Assert.AreEqual(expected, actual);
        }
    }
}
