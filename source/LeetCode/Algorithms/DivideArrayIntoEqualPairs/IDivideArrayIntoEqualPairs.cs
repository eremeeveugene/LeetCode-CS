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

namespace LeetCode.Algorithms.DivideArrayIntoEqualPairs;

/// <summary>
///     https://leetcode.com/problems/divide-array-into-equal-pairs/description/
/// </summary>
public interface IDivideArrayIntoEqualPairs
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> can be divided into pairs such that both elements of each pair
    ///     are equal.
    /// </summary>
    /// <param name="nums">The array of integers to divide into pairs.</param>
    /// <returns><see langword="true" /> if such a division exists; otherwise, <see langword="false" />.</returns>
    bool DivideArray(int[] nums);
}