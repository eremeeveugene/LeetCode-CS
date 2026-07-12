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

namespace LeetCode.Algorithms.FindTheDuplicateNumber;

/// <summary>
///     https://leetcode.com/problems/find-the-duplicate-number/
/// </summary>
public interface IFindTheDuplicateNumber
{
    /// <summary>
    ///     Finds the single repeated number in <paramref name="nums" />, which contains n + 1 integers in the range [1, n].
    /// </summary>
    /// <param name="nums">The array of integers containing exactly one repeated number.</param>
    /// <returns>The repeated number in <paramref name="nums" />.</returns>
    int FindDuplicate(int[] nums);
}