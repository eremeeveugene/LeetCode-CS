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

namespace LeetCode.Algorithms.MajorityElement;

/// <summary>
///     https://leetcode.com/problems/majority-element/description/
/// </summary>
public interface IMajorityElement
{
    /// <summary>
    ///     Finds the majority element of <paramref name="nums" />, i.e. the element that appears more than
    ///     ⌊n / 2⌋ times. The majority element is guaranteed to exist in the array.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>The element that appears more than ⌊n / 2⌋ times in <paramref name="nums" />.</returns>
    int MajorityElement(int[] nums);
}