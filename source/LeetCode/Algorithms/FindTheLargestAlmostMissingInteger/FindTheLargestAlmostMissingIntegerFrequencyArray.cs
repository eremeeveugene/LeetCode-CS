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

namespace LeetCode.Algorithms.FindTheLargestAlmostMissingInteger;

/// <inheritdoc />
public sealed class FindTheLargestAlmostMissingIntegerFrequencyArray : IFindTheLargestAlmostMissingInteger
{
    private const int MaxNum = 50;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int LargestInteger(int[] nums, int k)
    {
        var n = nums.Length;

        Span<int> numsFrequencies = stackalloc int[MaxNum + 1];

        var maxNum = -1;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            numsFrequencies[num]++;

            maxNum = Math.Max(maxNum, num);
        }

        if (k == n)
        {
            return maxNum;
        }

        if (k == 1)
        {
            for (var num = MaxNum; num >= 0; num--)
            {
                if (numsFrequencies[num] == 1)
                {
                    return num;
                }
            }

            return -1;
        }

        var firstNum = nums[0];
        var lastNum = nums[^1];

        var firstCandidate = numsFrequencies[firstNum] == 1 ? firstNum : -1;
        var lastCandidate = numsFrequencies[lastNum] == 1 ? lastNum : -1;

        return Math.Max(firstCandidate, lastCandidate);
    }
}