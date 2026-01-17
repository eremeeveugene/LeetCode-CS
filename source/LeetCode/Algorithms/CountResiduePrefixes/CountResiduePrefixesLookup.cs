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

namespace LeetCode.Algorithms.CountResiduePrefixes;

/// <inheritdoc />
public sealed class CountResiduePrefixesLookup : ICountResiduePrefixes
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int ResiduePrefixes(string s)
    {
        var result = 0;

        Span<bool> lookup = stackalloc bool[AlphabetLength];

        var distinctCount = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var index = s[i] - 'a';

            if (!lookup[index])
            {
                distinctCount++;

                lookup[index] = true;
            }

            if (distinctCount == (i + 1) % 3)
            {
                result++;
            }
        }

        return result;
    }
}