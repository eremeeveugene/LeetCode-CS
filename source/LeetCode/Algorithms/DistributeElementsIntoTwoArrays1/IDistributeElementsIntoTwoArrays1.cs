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

namespace LeetCode.Algorithms.DistributeElementsIntoTwoArrays1;

/// <summary>
///     https://leetcode.com/problems/distribute-elements-into-two-arrays-i/description/
/// </summary>
public interface IDistributeElementsIntoTwoArrays1
{
    /// <summary>
    ///     Distributes the elements of <paramref name="nums" /> into two arrays according to their last elements and
    ///     returns the concatenation of the first and second arrays.
    /// </summary>
    /// <param name="nums">The array of distinct integers to distribute.</param>
    /// <returns>The two distributed arrays concatenated in order.</returns>
    int[] ResultArray(int[] nums);
}