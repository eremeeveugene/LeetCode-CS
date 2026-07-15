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

namespace LeetCode.Algorithms.UniqueMiddleElement;

/// <summary>
///     https://leetcode.com/problems/unique-middle-element/description/
/// </summary>
public interface IUniqueMiddleElement
{
    /// <summary>
    ///     Determines whether the middle element of the odd-length array <paramref name="nums" /> appears exactly once.
    /// </summary>
    /// <param name="nums">The odd-length array to evaluate.</param>
    /// <returns><c>true</c> if the middle element appears exactly once; otherwise, <c>false</c>.</returns>
    bool HasUniqueMiddleElement(int[] nums);
}