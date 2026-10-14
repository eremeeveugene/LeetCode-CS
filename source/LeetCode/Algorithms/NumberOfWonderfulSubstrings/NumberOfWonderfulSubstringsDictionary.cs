// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.NumberOfWonderfulSubstrings;

/// <inheritdoc />
public sealed class NumberOfWonderfulSubstringsDictionary : INumberOfWonderfulSubstrings
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * k), where n is the length of the string and k is the number of characters in the alphabet
    ///     (which is constant, k = 10)
    ///     Space complexity - O(n)
    /// </remarks>
    public long WonderfulSubstrings(string word)
    {
        long count = 0;

        var bitmask = 0;

        var maskToCountDictionary = new Dictionary<int, int> { [0] = 1 };

        for (var i = 0; i < word.Length; i++)
        {
            var c = word[i];

            bitmask ^= 1 << (c - 'a');

            if (maskToCountDictionary.TryGetValue(bitmask, out var bitmaskCount))
            {
                count += bitmaskCount;
            }

            for (var j = 0; j < 10; j++)
            {
                var tempMask = bitmask ^ (1 << j);

                if (maskToCountDictionary.TryGetValue(tempMask, out var tempMaskCount))
                {
                    count += tempMaskCount;
                }
            }

            if (!maskToCountDictionary.TryAdd(bitmask, 1))
            {
                maskToCountDictionary[bitmask]++;
            }
        }

        return count;
    }
}