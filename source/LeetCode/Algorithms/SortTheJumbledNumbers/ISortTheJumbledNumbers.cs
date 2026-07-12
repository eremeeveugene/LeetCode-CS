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

namespace LeetCode.Algorithms.SortTheJumbledNumbers;

/// <summary>
///     https://leetcode.com/problems/sort-the-jumbled-numbers/
/// </summary>
public interface ISortTheJumbledNumbers
{
    /// <summary>
    ///     Sorts <paramref name="nums" /> according to the mapped value of each number, obtained by replacing
    ///     each digit using <paramref name="mapping" />, preserving relative order for equal mapped values.
    /// </summary>
    /// <param name="mapping">The array where mapping[i] gives the digit that digit i maps to.</param>
    /// <param name="nums">The array of integers to sort by their mapped value.</param>
    /// <returns>The array <paramref name="nums" /> sorted by the mapped value of each element.</returns>
    int[] SortJumbled(int[] mapping, int[] nums);
}