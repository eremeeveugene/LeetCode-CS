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

namespace LeetCode.Algorithms.RemoveElement;

/// <summary>
///     https://leetcode.com/problems/remove-element/description/
/// </summary>
public interface IRemoveElement
{
    /// <summary>
    ///     Removes all occurrences of <paramref name="val" /> from <paramref name="nums" /> in place, preserving the
    ///     relative order of the remaining elements.
    /// </summary>
    /// <param name="nums">The array of integers to remove values from in place.</param>
    /// <param name="val">The value to remove from <paramref name="nums" />.</param>
    /// <returns>The number of elements remaining at the front of <paramref name="nums" /> after removal.</returns>
    int RemoveElement(int[] nums, int val);
}