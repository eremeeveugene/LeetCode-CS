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

namespace LeetCode.Algorithms.MaximumUniqueSubarraySumAfterDeletion;

/// <inheritdoc />
public class MaximumUniqueSubarraySumAfterDeletionHashSet : IMaximumUniqueSubarraySumAfterDeletion
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxSum(int[] nums)
    {
        var maxSum = 0;
        var maxElement = int.MinValue;

        var numsHashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            maxElement = Math.Max(maxElement, num);

            if (num > 0 && numsHashSet.Add(num))
            {
                maxSum += num;
            }
        }

        return maxSum == 0 ? maxElement : maxSum;
    }
}