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

namespace LeetCode.Algorithms.MaximumBeautyOfAnArrayAfterApplyingOperation;

/// <inheritdoc />
public class MaximumBeautyOfAnArrayAfterApplyingOperationDifferenceArray : IMaximumBeautyOfAnArrayAfterApplyingOperation
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MaximumBeauty(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return 1;
        }

        var maxBeauty = 0;
        var maxValue = nums.Max();

        var count = new int[maxValue + 2];

        foreach (var num in nums)
        {
            count[Math.Max(num - k, 0)]++;
            count[Math.Min(num + k + 1, maxValue + 1)]--;
        }

        var currentSum = 0;

        foreach (var val in count)
        {
            currentSum += val;
            maxBeauty = Math.Max(maxBeauty, currentSum);
        }

        return maxBeauty;
    }
}