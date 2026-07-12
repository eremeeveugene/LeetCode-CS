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

namespace LeetCode.Algorithms.BuildArrayFromPermutation;

/// <summary>
///     https://leetcode.com/problems/build-array-from-permutation/
/// </summary>
public interface IBuildArrayFromPermutation
{
    /// <summary>
    ///     Builds an array where the i-th element is nums[nums[i]] for the zero-based permutation
    ///     <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The zero-based permutation.</param>
    /// <returns>The array where the i-th element equals nums[nums[i]].</returns>
    int[] BuildArray(int[] nums);
}