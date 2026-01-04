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

namespace LeetCode.Algorithms.SmallestMissingMultipleOfK;

/// <inheritdoc />
public class SmallestMissingMultipleOfKLookup : ISmallestMissingMultipleOfK
{
    private const int MaxValue = 100;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MissingMultiple(int[] nums, int k)
    {
        Span<bool> numsLookup = stackalloc bool[MaxValue + 1];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            numsLookup[num] = true;
        }

        if (k > MaxValue / 2)
        {
            return numsLookup[k] ? k * 2 : k;
        }

        for (var num = k; num <= MaxValue; num += k)
        {
            if (!numsLookup[num])
            {
                return num;
            }
        }

        return ((MaxValue / k) + 1) * k;
    }
}