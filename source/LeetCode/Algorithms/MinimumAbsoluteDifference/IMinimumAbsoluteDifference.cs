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

namespace LeetCode.Algorithms.MinimumAbsoluteDifference;

/// <summary>
///     https://leetcode.com/problems/minimum-absolute-difference/description/
/// </summary>
public interface IMinimumAbsoluteDifference
{
    /// <summary>
    ///     Finds all pairs of elements from <paramref name="arr" /> whose absolute difference equals the minimum
    ///     absolute difference between any two elements of the array.
    /// </summary>
    /// <param name="arr">The array of distinct integers to scan.</param>
    /// <returns>A list of pairs, each in ascending order, that achieve the minimum absolute difference.</returns>
    IList<IList<int>> MinimumAbsDifference(int[] arr);
}