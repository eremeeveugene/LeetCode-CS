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

namespace LeetCode.Algorithms.AbsoluteDifferenceBetweenMaximumAndMinimumKElements;

/// <inheritdoc />
public sealed class AbsoluteDifferenceBetweenMaximumAndMinimumKElementsSorting :
    IAbsoluteDifferenceBetweenMaximumAndMinimumKElements
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int AbsDifference(int[] nums, int k)
    {
        Array.Sort(nums);

        var result = 0;

        for (var i = 0; i < k; i++)
        {
            result += nums[i];
            result -= nums[nums.Length - 1 - i];
        }

        return Math.Abs(result);
    }
}