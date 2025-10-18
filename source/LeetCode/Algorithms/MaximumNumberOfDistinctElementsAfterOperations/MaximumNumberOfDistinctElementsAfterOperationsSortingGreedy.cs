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

namespace LeetCode.Algorithms.MaximumNumberOfDistinctElementsAfterOperations;

public class MaximumNumberOfDistinctElementsAfterOperationsSortingGreedy :
    IMaximumNumberOfDistinctElementsAfterOperations
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MaxDistinctElements(int[] nums, int k)
    {
        var numsLength = nums.Length;

        if (k >= numsLength)
        {
            return numsLength;
        }

        Array.Sort(nums);

        if (nums[0] == nums[^1])
        {
            return Math.Min(numsLength, (2 * k) + 1);
        }

        var previous = nums[0] - k;

        var distinctCount = 1;

        for (var i = 1; i < numsLength; i++)
        {
            var num = nums[i];

            var current = Math.Min(Math.Max(previous + 1, num - k), num + k);

            if (current <= previous)
            {
                continue;
            }

            distinctCount++;

            previous = current;
        }

        return distinctCount;
    }
}