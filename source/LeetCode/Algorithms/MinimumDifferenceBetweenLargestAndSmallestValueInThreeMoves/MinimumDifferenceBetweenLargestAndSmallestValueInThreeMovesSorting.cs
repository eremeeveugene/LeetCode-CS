// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves;

/// <inheritdoc />
public class MinimumDifferenceBetweenLargestAndSmallestValueInThreeMovesSorting :
    IMinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinDifference(int[] nums)
    {
        if (nums.Length <= 4)
        {
            return 0;
        }

        Array.Sort(nums);

        var minDifference = int.MaxValue;

        for (var left = 0; left < 4; left++)
        {
            var right = nums.Length - 4 + left;

            minDifference = Math.Min(minDifference, nums[right] - nums[left]);
        }

        return minDifference;
    }
}