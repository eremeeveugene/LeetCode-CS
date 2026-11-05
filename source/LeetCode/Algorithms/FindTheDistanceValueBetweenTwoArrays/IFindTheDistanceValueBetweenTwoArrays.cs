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

namespace LeetCode.Algorithms.FindTheDistanceValueBetweenTwoArrays;

/// <summary>
///     https://leetcode.com/problems/find-the-distance-value-between-two-arrays/description/
/// </summary>
public interface IFindTheDistanceValueBetweenTwoArrays
{
    /// <summary>
    ///     Finds the distance value between two arrays, which is the number of elements in <paramref name="arr1" />
    ///     for which no element of <paramref name="arr2" /> is within an absolute difference of at most
    ///     <paramref name="d" />.
    /// </summary>
    /// <param name="arr1">The array whose elements are counted.</param>
    /// <param name="arr2">The array whose elements are compared against.</param>
    /// <param name="d">The maximum absolute difference that disqualifies an element of <paramref name="arr1" />.</param>
    /// <returns>The distance value between the two arrays.</returns>
    int FindTheDistanceValue(int[] arr1, int[] arr2, int d);
}