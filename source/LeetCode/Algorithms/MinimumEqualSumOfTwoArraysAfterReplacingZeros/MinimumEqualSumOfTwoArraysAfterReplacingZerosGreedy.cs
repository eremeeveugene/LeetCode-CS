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

namespace LeetCode.Algorithms.MinimumEqualSumOfTwoArraysAfterReplacingZeros;

/// <inheritdoc />
public sealed class MinimumEqualSumOfTwoArraysAfterReplacingZerosGreedy : IMinimumEqualSumOfTwoArraysAfterReplacingZeros
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public long MinSum(int[] nums1, int[] nums2)
    {
        long nums1Sum = 0;
        var nums1ZeroCount = 0;

        foreach (var num in nums1)
        {
            if (num == 0)
            {
                nums1Sum++;
                nums1ZeroCount++;
            }
            else
            {
                nums1Sum += num;
            }
        }

        long nums2Sum = 0;
        var nums2ZeroCount = 0;

        foreach (var num in nums2)
        {
            if (num == 0)
            {
                nums2ZeroCount++;
                nums2Sum++;
            }
            else
            {
                nums2Sum += num;
            }
        }

        if ((nums2Sum > nums1Sum && nums1ZeroCount == 0) ||
            (nums1Sum > nums2Sum && nums2ZeroCount == 0))
        {
            return -1;
        }

        return Math.Max(nums1Sum, nums2Sum);
    }
}