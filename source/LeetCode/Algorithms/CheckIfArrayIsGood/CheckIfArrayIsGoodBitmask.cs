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
public sealed class CheckIfArrayIsGoodBitmask : ICheckIfArrayIsGood
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

        ulong lowBits = 0;
        ulong highBits = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num > maxValue)
            {
                return false;
            }

            ref var bits = ref num < 64 ? ref lowBits : ref highBits;

            var shift = num < 64 ? num : num - 64;
            var bit = 1UL << shift;

            if ((bits & bit) == 0)
            {
                bits |= bit;

                continue;
            }

            if (num != maxValue || hasTwoOccurrencesOfMaxValue)
            {
                return false;
            }

            hasTwoOccurrencesOfMaxValue = true;
        }

        return hasTwoOccurrencesOfMaxValue;
    }
}