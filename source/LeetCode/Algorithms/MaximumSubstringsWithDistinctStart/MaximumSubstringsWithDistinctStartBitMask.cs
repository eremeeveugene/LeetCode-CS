// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MaximumSubstringsWithDistinctStart;

/// <inheritdoc />
public sealed class MaximumSubstringsWithDistinctStartBitMask : MaximumSubstringsWithDistinctStartBase
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public override int MaxDistinct(string s)
    {
        var mask = 0;
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var index = GetIndex(s[i]);
            var bit = 1 << index;

            if ((mask & bit) != 0)
            {
                continue;
            }

            mask |= bit;

            result++;

            if (result == 26)
            {
                break;
            }
        }

        return result;
    }
}