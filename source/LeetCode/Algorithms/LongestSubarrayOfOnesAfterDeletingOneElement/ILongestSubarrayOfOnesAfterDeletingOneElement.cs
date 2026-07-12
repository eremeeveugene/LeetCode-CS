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

namespace LeetCode.Algorithms.LongestSubarrayOfOnesAfterDeletingOneElement;

/// <summary>
///     https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element/description/
/// </summary>
public interface ILongestSubarrayOf1AfterDeletingOneElement
{
    /// <summary>
    ///     Finds the length of the longest subarray of 1s in the binary array <paramref name="nums" /> after deleting
    ///     exactly one element.
    /// </summary>
    /// <param name="nums">The binary array from which exactly one element must be deleted.</param>
    /// <returns>The length of the longest subarray containing only 1s after deleting one element.</returns>
    int LongestSubarray(int[] nums);
}