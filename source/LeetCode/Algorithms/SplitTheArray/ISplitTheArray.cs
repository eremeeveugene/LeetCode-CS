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

namespace LeetCode.Algorithms.SplitTheArray;

/// <summary>
///     https://leetcode.com/problems/split-the-array/description/
/// </summary>
public interface ISplitTheArray
{
    /// <summary>
    ///     Determines whether the even-length array <paramref name="nums" /> can be split into two arrays of
    ///     equal length, each containing only distinct elements.
    /// </summary>
    /// <param name="nums">The array of integers to split.</param>
    /// <returns><see langword="true" /> if the split is possible; otherwise, <see langword="false" />.</returns>
    bool IsPossibleToSplit(int[] nums);
}