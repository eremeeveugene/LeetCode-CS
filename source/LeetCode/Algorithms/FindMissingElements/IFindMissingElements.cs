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

namespace LeetCode.Algorithms.FindMissingElements;

/// <summary>
///     https://leetcode.com/problems/find-missing-elements/description/
/// </summary>
public interface IFindMissingElements
{
    /// <summary>
    ///     Finds all numbers between the minimum and maximum values of <paramref name="nums" /> that are missing from the
    ///     array.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The list of numbers in the range of <paramref name="nums" /> that do not appear in the array.</returns>
    IList<int> FindMissingElements(int[] nums);
}