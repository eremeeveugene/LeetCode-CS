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

namespace LeetCode.Algorithms.DivideArrayIntoArraysWithMaxDifference;

/// <summary>
///     https://leetcode.com/problems/divide-array-into-arrays-with-max-difference/description/
/// </summary>
public interface IDivideArrayIntoArraysWithMaxDifference
{
    /// <summary>
    ///     Divides <paramref name="nums" /> into groups of 3 such that the elements of each group are within
    ///     <paramref name="k" /> of each other.
    /// </summary>
    /// <param name="nums">The array of integers to divide into groups.</param>
    /// <param name="k">The maximum allowed difference between the elements of a group.</param>
    /// <returns>An array of groups of 3 elements satisfying the difference constraint, or an empty array if not possible.</returns>
    int[][] DivideArray(int[] nums, int k);
}