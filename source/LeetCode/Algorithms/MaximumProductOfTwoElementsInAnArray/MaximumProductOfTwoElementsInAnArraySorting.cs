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

namespace LeetCode.Algorithms.MaximumProductOfTwoElementsInAnArray;

/// <inheritdoc />
public class MaximumProductOfTwoElementsInAnArraySorting : IMaximumProductOfTwoElementsInAnArray
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n) or O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxProduct(int[] nums)
    {
        Array.Sort(nums);

        return (nums[^1] - 1) * (nums[^2] - 1);
    }
}