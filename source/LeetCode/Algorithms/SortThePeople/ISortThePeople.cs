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

namespace LeetCode.Algorithms.SortThePeople;

/// <summary>
///     https://leetcode.com/problems/sort-the-people/
/// </summary>
public interface ISortThePeople
{
    /// <summary>
    ///     Sorts <paramref name="names" /> in descending order of the corresponding heights in
    ///     <paramref name="heights" />.
    /// </summary>
    /// <param name="names">The array of people's names.</param>
    /// <param name="heights">The array of distinct heights, where heights[i] is the height of names[i].</param>
    /// <returns>The names sorted in descending order of height.</returns>
    string[] SortPeople(string[] names, int[] heights);
}