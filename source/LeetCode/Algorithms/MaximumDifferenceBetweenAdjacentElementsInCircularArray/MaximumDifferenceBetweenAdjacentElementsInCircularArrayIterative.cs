// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MaximumDifferenceBetweenAdjacentElementsInCircularArray;

/// <inheritdoc />
public class MaximumDifferenceBetweenAdjacentElementsInCircularArrayIterative :
    IMaximumDifferenceBetweenAdjacentElementsInCircularArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxAdjacentDistance(int[] nums)
    {
        var maxAdjacentDistance = Math.Abs(nums[0] - nums[^1]);

        for (var i = 0; i < nums.Length - 1; i++)
        {
            var adjacentDistance = Math.Abs(nums[i] - nums[i + 1]);

            maxAdjacentDistance = Math.Max(maxAdjacentDistance, adjacentDistance);
        }

        return maxAdjacentDistance;
    }
}