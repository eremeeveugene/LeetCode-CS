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

namespace LeetCode.Algorithms.MaximumProductOfThreeNumbers;

/// <inheritdoc />
public sealed class MaximumProductOfThreeNumbersSorting : IMaximumProductOfThreeNumbers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int MaximumProduct(int[] nums)
    {
        Array.Sort(nums);

        var n = nums.Length;

        var largestProduct = nums[n - 1] * nums[n - 2] * nums[n - 3];

        var smallestPairProduct = nums[0] * nums[1] * nums[n - 1];

        return Math.Max(largestProduct, smallestPairProduct);
    }
}