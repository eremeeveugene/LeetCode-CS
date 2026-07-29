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

namespace LeetCode.Algorithms.NRepeatedElementInSize2NArray;

/// <inheritdoc />
public sealed class NRepeatedElementInSize2NArrayLookup : INRepeatedElementInSize2NArray
{
    private const int MaxValue = 10_000;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int RepeatedNTimes(int[] nums)
    {
        Span<bool> numsLookup = stackalloc bool[MaxValue + 1];

        var n = nums.Length;

        var i = 0;

        while (i < n)
        {
            var num = nums[i];

            if (!numsLookup[num])
            {
                break;
            }

            numsLookup[num] = true;

            i++;
        }

        return nums[i];
    }
}