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

namespace LeetCode.Algorithms.MajorityElement2;

/// <summary>
///     https://leetcode.com/problems/majority-element-ii/description/
/// </summary>
public interface IMajorityElement2
{
    /// <summary>
    ///     Finds all elements of <paramref name="nums" /> that appear more than [n / 3] times.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>A list of the elements that appear more than [n / 3] times in <paramref name="nums" />, in any order.</returns>
    IList<int> MajorityElement(int[] nums);
}