// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.GroupAnagrams
{
    public static class Algorithm
    {
        public static List<List<string>> Run(List<string> words)
        {
            if(words == null || words.Count == 0)
            {
                return null;
            }

            var anagrams = new Dictionary<string, List<string>>();
            foreach (var word in words)
            {
                var chars = word.ToCharArray();
                Array.Sort(chars);
                var sortedWord = new string(chars);
                if(anagrams.TryGetValue(sortedWord, out var value))
                {
                    value.Add(word);
                }
                else
                {
                    anagrams[sortedWord] = [word];
                }
            }

            return [.. anagrams.Values];
        }
    }
}
