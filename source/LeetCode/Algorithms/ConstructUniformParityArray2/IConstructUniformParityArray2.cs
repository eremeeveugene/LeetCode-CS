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

namespace LeetCode.Algorithms.ConstructUniformParityArray2;

/// <summary>
///     https://leetcode.com/problems/construct-uniform-parity-array-ii/description/
/// </summary>
public interface IConstructUniformParityArray2
{
    /// <summary>
    ///     Determines whether an array <c>nums2</c> of the same length as <paramref name="nums1" /> can be constructed such
    ///     that all of its elements share the same parity, where each element <c>nums2[i]</c> is either
    ///     <c>nums1[i]</c> or <c>nums1[i] - nums1[j]</c> for some <c>j != i</c> with <c>nums1[i] - nums1[j] &gt;= 1</c>.
    /// </summary>
    /// <param name="nums1">An array of distinct positive integers.</param>
    /// <returns><c>true</c> if such a uniform-parity array can be constructed; otherwise, <c>false</c>.</returns>
    bool UniformArray(int[] nums1);
}