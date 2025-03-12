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

namespace LeetCode.Algorithms.MaximumCountOfPositiveIntegerAndNegativeInteger;

/// <inheritdoc />
public class MaximumCountOfPositiveIntegerAndNegativeIntegerBinarySearch :
    IMaximumCountOfPositiveIntegerAndNegativeInteger
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaximumCount(int[] nums)
    {
        var negativeCount = FindFirstIndex(nums, 0);
        var positiveCount = nums.Length - FindFirstIndex(nums, 1);

        return Math.Max(negativeCount, positiveCount);
    }

    private static int FindFirstIndex(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length;

        while (left < right)
        {
            var mid = left + ((right - left) / 2);

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }
}