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

namespace LeetCode.Algorithms.MinimumAbsoluteDifferenceBetweenTwoValues;

/// <inheritdoc />
public sealed class MinimumAbsoluteDifferenceBetweenTwoValuesTwoPointers : IMinimumAbsoluteDifferenceBetweenTwoValues
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinAbsoluteDifference(int[] nums)
    {
        var n = nums.Length;

        var minAbsoluteDifference = int.MaxValue;

        var indexI = -1;
        var indexJ = -1;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num == 0)
            {
                continue;
            }

            if (num == 1)
            {
                indexI = i;
            }
            else
            {
                indexJ = i;
            }

            if (indexI < 0 || indexJ < 0)
            {
                continue;
            }

            var absoluteDifference = Math.Abs(indexI - indexJ);

            minAbsoluteDifference = Math.Min(minAbsoluteDifference, absoluteDifference);
        }

        if (minAbsoluteDifference == int.MaxValue)
        {
            return -1;
        }

        return minAbsoluteDifference;
    }
}