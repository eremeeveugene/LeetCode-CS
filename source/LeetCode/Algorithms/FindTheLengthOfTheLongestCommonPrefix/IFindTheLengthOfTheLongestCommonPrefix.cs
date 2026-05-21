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

namespace LeetCode.Algorithms.FindTheLengthOfTheLongestCommonPrefix;

/// <summary>
///     https://leetcode.com/problems/find-the-length-of-the-longest-common-prefix/description/
/// </summary>
public interface IFindTheLengthOfTheLongestCommonPrefix
{
    /// <summary>
    ///     Finds the length of the longest common prefix between any pair of integers from two arrays.
    /// </summary>
    /// <param name="arr1">The first integer array.</param>
    /// <param name="arr2">The second integer array.</param>
    /// <returns>The length of the longest common prefix between any integer from <paramref name="arr1" /> and any integer from <paramref name="arr2" />.</returns>
    int LongestCommonPrefix(int[] arr1, int[] arr2);
}