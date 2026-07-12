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

/// <summary>
///     https://leetcode.com/problems/maximum-beauty-of-an-array-after-applying-operation/description/
/// </summary>
public interface IMaximumBeautyOfAnArrayAfterApplyingOperation
{
    /// <summary>
    ///     Replaces each element of <paramref name="nums" /> at most once with any value in the range
    ///     [nums[i] - <paramref name="k" />, nums[i] + <paramref name="k" />] to maximize the number of elements that can
    ///     be made equal.
    /// </summary>
    /// <param name="nums">The array of integers to operate on.</param>
    /// <param name="k">The maximum amount by which each element's value may be shifted in either direction.</param>
    /// <returns>The maximum possible beauty, i.e. the largest count of elements that can be made equal.</returns>
    int MaximumBeauty(int[] nums, int k);
}