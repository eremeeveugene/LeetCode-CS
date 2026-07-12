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

namespace LeetCode.Algorithms.MaximumDistanceInArrays;

/// <summary>
///     https://leetcode.com/problems/maximum-distance-in-arrays/
/// </summary>
public interface IMaximumDistanceInArrays
{
    /// <summary>
    ///     Finds the maximum absolute difference between an element from one array and an element from a different
    ///     array within the sorted arrays in <paramref name="arrays" />.
    /// </summary>
    /// <param name="arrays">The list of sorted integer arrays to choose two elements from, taken from different arrays.</param>
    /// <returns>The maximum absolute distance between elements taken from two different arrays in <paramref name="arrays" />.</returns>
    int MaxDistance(IList<IList<int>> arrays);
}