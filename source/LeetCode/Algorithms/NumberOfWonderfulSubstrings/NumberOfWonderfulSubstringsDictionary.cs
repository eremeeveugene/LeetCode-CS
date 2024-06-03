// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.NumberOfWonderfulSubstrings;

public class NumberOfWonderfulSubstringsDictionary : INumberOfWonderfulSubstrings
{
    /// <summary>
    ///     Time complexity - O(n * k), where n is the length of the string and k is the number of characters in the alphabet
    ///     (which is constant, k = 10)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public long WonderfulSubstrings(string word)
    {
        long count = 0;

        var bitmask = 0;

        var maskCount = new Dictionary<int, int> { [0] = 1 };

        foreach (var c in word)
        {
            bitmask ^= 1 << (c - 'a');

            if (maskCount.TryGetValue(bitmask, out var bitmaskCount))
            {
                count += bitmaskCount;
            }

            for (var i = 0; i < 10; i++)
            {
                var tempMask = bitmask ^ (1 << i);

                if (maskCount.TryGetValue(tempMask, out var tempMaskCount))
                {
                    count += tempMaskCount;
                }
            }

            if (!maskCount.TryAdd(bitmask, 1))
            {
                maskCount[bitmask]++;
            }
        }

        return count;
    }
}