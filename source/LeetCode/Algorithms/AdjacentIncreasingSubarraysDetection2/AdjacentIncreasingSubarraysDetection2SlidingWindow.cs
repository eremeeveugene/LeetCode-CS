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

namespace LeetCode.Algorithms.AdjacentIncreasingSubarraysDetection2;

/// <inheritdoc />
public sealed class AdjacentIncreasingSubarraysDetection2SlidingWindow : IAdjacentIncreasingSubarraysDetection2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxIncreasingSubarrays(IList<int> nums)
    {
        var n = nums.Count;

        var result = 1;

        var previousLength = 0;
        var currentLength = 1;

        for (var i = 0; i < n - 1; i++)
        {
            var num = nums[i];
            var nextNum = nums[i + 1];

            if (num < nextNum)
            {
                currentLength++;
            }
            else
            {
                previousLength = currentLength;

                currentLength = 1;
            }

            var sameRunLength = currentLength / 2;
            var adjacentRunsLength = Math.Min(previousLength, currentLength);

            result = Math.Max(result, Math.Max(sameRunLength, adjacentRunsLength));
        }

        return result;
    }
}