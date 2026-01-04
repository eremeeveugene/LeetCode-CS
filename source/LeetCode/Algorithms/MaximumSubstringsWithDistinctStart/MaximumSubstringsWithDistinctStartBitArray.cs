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

using System.Collections;

namespace LeetCode.Algorithms.MaximumSubstringsWithDistinctStart;

/// <inheritdoc />
public sealed class MaximumSubstringsWithDistinctStartBitArray : MaximumSubstringsWithDistinctStartBase
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public override int MaxDistinct(string s)
    {
        var result = 0;

        var charactersLookup = new BitArray(AlphabetLength);

        for (var i = 0; i < s.Length; i++)
        {
            var index = GetIndex(s[i]);

            if (charactersLookup[index])
            {
                continue;
            }

            charactersLookup[index] = true;

            result++;
        }

        return result;
    }
}