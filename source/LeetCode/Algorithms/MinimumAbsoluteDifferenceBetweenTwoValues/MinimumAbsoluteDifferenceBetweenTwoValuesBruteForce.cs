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
public sealed class MinimumAbsoluteDifferenceBetweenTwoValuesBruteForce : IMinimumAbsoluteDifferenceBetweenTwoValues
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinAbsoluteDifference(int[] nums)
    {
        var n = nums.Length;

        var minAbsoluteDifference = int.MaxValue;

        for (var i = 0; i < n; i++)
        {
            var numI = nums[i];

            if (numI != 1)
            {
                continue;
            }

            for (var j = 0; j < n; j++)
            {
                var numJ = nums[j];

                if (numJ != 2)
                {
                    continue;
                }

                var absoluteDifference = Math.Abs(i - j);

                minAbsoluteDifference = Math.Min(minAbsoluteDifference, absoluteDifference);
            }
        }

        if (minAbsoluteDifference == int.MaxValue)
        {
            return -1;
        }

        return minAbsoluteDifference;
    }
}