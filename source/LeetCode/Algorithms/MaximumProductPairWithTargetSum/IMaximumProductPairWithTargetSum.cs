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

namespace LeetCode.Algorithms.MaximumProductPairWithTargetSum;

/// <summary>
///     https://leetcode.com/problems/maximum-product-pair-with-target-sum/description/
/// </summary>
public interface IMaximumProductPairWithTargetSum
{
    /// <summary>
    ///     Finds a pair of distinct indices (i, j) such that nums[i] + nums[j] == target and nums[i] > nums[j], whose
    ///     product nums[i] * nums[j] is maximum among all such pairs.
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <param name="target">The required sum of the pair.</param>
    /// <returns>The indices [i, j] of the pair with the maximum product, or [-1, -1] if no valid pair exists.</returns>
    int[] MaxProductPair(int[] nums, int target);
}