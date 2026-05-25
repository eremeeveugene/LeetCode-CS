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

namespace LeetCode.Algorithms.CheckIfArrayIsGood;

/// <inheritdoc />
public sealed class CheckIfArrayIsGoodLookup : ICheckIfArrayIsGood
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsGood(int[] nums)
    {
        var n = nums.Length;

        if (n < 2)
        {
            return false;
        }

        var maxValue = n - 1;

        var hasTwoOccurrencesOfMaxValue = false;

        Span<bool> numsLookup = stackalloc bool[maxValue + 1];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num > maxValue)
            {
                return false;
            }

            if (numsLookup[num])
            {
                if (num == maxValue && !hasTwoOccurrencesOfMaxValue)
                {
                    hasTwoOccurrencesOfMaxValue = true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                numsLookup[num] = true;
            }
        }

        return hasTwoOccurrencesOfMaxValue;
    }
}