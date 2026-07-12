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

namespace LeetCode.Algorithms.DivideStringIntoGroupsOfSizeK;

/// <summary>
///     https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/description/
/// </summary>
public interface IDivideStringIntoGroupsOfSizeK
{
    /// <summary>
    ///     Divides <paramref name="s" /> into groups of size <paramref name="k" />, padding the final group with
    ///     <paramref name="fill" /> characters if needed.
    /// </summary>
    /// <param name="s">The string to divide into groups.</param>
    /// <param name="k">The required size of each group.</param>
    /// <param name="fill">The character used to pad the last group if it has fewer than <paramref name="k" /> characters.</param>
    /// <returns>An array of strings, each of length <paramref name="k" />, representing the groups.</returns>
    string[] DivideString(string s, int k, char fill);
}