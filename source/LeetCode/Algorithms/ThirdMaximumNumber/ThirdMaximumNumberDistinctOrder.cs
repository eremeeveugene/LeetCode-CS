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

namespace LeetCode.Algorithms.ThirdMaximumNumber;

/// <inheritdoc />
public sealed class ThirdMaximumNumberDistinctOrder : IThirdMaximumNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int ThirdMax(int[] nums)
    {
        var numsLength = nums.Length;

        switch (numsLength)
        {
            case 1:
                return nums[0];
            case 2:
                return Math.Max(nums[0], nums[1]);
        }

        var sortedNums = new int[numsLength];

        Array.Copy(nums, sortedNums, numsLength);

        Array.Sort(sortedNums);

        var distinctCount = 1;

        for (var i = numsLength - 2; i >= 0; i--)
        {
            if (sortedNums[i] == sortedNums[i + 1])
            {
                continue;
            }

            distinctCount++;

            if (distinctCount == 3)
            {
                return sortedNums[i];
            }
        }

        return sortedNums[^1];
    }
}