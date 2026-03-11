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

    /// <summary>
    ///     Time
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RepeatedNTimes(int[] nums)
    {
        Span<bool> numsLookup = stackalloc bool[MaxValue + 1];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (numsLookup[num])
            {
                return num;
            }

            numsLookup[num] = true;
        }

        return 0;
    }
}