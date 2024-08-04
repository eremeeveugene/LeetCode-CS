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

namespace LeetCode.Algorithms.RangeSumOfSortedSubarraySums;

/// <inheritdoc />
public class RangeSumOfSortedSubarraySumsBruteForce : IRangeSumOfSortedSubarraySums
{
    /// <summary>
    ///     Time complexity - O(n^2 log n)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="n"></param>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public int RangeSum(int[] nums, int n, int left, int right)
    {
        var sumsList = new List<int>();

        for (var i = 0; i < n; i++)
        {
            var sum = 0;

            for (var j = i; j < n; j++)
            {
                sum += nums[j];

                sumsList.Add(sum);
            }
        }

        var sortedSums = sumsList.Order().ToArray();

        var rangeSum = 0;

        for (var i = left - 1; i < right; i++)
        {
            rangeSum += sortedSums[i];
            rangeSum %= 1000000007;
        }

        return rangeSum;
    }
}