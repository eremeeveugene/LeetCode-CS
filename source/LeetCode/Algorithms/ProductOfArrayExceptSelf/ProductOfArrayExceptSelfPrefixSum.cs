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

namespace LeetCode.Algorithms.ProductOfArrayExceptSelf;

/// <inheritdoc />
public sealed class ProductOfArrayExceptSelfPrefixSum : IProductOfArrayExceptSelf
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] ProductExceptSelf(int[] nums)
    {
        var n = nums.Length;

        Span<int> prefix = stackalloc int[n + 1];

        prefix[0] = 1;

        for (var i = 1; i <= n; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        Span<int> suffix = stackalloc int[n + 1];

        suffix[n] = 1;

        for (var i = n - 1; i >= 0; i--)
        {
            suffix[i] = suffix[i + 1] * nums[i];
        }

        for (var i = 0; i < n; i++)
        {
            nums[i] = prefix[i] * suffix[i + 1];
        }

        return nums;
    }
}