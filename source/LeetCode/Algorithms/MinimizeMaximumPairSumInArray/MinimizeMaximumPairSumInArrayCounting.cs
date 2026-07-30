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

namespace LeetCode.Algorithms.MinimizeMaximumPairSumInArray;

/// <inheritdoc />
public sealed class MinimizeMaximumPairSumInArrayCounting : IMinimizeMaximumPairSumInArray
{
    private const int MaxValue = 100_000;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O()
    /// </remarks>
    public int MinPairSum(int[] nums)
    {
        Span<int> frequencies = stackalloc int[MaxValue + 1];

        foreach (var num in nums)
        {
            frequencies[num]++;
        }

        var left = 1;
        var right = MaxValue;

        var result = 0;

        var remaining = nums.Length;

        while (remaining > 0)
        {
            while (frequencies[left] == 0)
            {
                left++;
            }

            while (frequencies[right] == 0)
            {
                right--;
            }

            var sum = left + right;

            result = Math.Max(result, sum);

            frequencies[left]--;
            frequencies[right]--;

            remaining -= 2;
        }

        return result;
    }
}