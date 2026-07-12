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

namespace LeetCode.Algorithms.IntersectionOfMultipleArrays;

/// <summary>
///     https://leetcode.com/problems/intersection-of-multiple-arrays/description/
/// </summary>
public interface IIntersectionOfMultipleArrays
{
    /// <summary>
    ///     Finds the integers that are present in every array of <paramref name="nums" />, sorted in ascending order.
    /// </summary>
    /// <param name="nums">The arrays of distinct positive integers.</param>
    /// <returns>The sorted list of integers present in each array of <paramref name="nums" />.</returns>
    IList<int> Intersection(int[][] nums);
}