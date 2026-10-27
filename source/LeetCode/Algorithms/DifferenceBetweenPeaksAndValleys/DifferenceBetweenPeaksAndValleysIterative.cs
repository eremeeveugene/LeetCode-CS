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

namespace LeetCode.Algorithms.DifferenceBetweenPeaksAndValleys;

/// <inheritdoc />
public sealed class DifferenceBetweenPeaksAndValleysIterative : IDifferenceBetweenPeaksAndValleys
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int PeakValleyDifference(int[] nums)
    {
        var n = nums.Length;

        var result = 0;

        for (var i = 1; i < n - 1; i++)
        {
            var previousNum = nums[i - 1];
            var num = nums[i];
            var nextNum = nums[i + 1];

            if (num > previousNum && num > nextNum)
            {
                result += num;
            }
            else if (num < previousNum && num < nextNum)
            {
                result -= num;
            }
        }

        return result;
    }
}