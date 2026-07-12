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

namespace LeetCode.Algorithms.FirstUniqueEvenElement;

/// <summary>
///     https://leetcode.com/problems/first-unique-even-element/description/
/// </summary>
public interface IFirstUniqueEvenElement
{
    /// <summary>
    ///     Finds the first even element in <paramref name="nums" /> that appears exactly once.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>The first unique even element, or -1 if no such element exists.</returns>
    int FirstUniqueEven(int[] nums);
}