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

namespace LeetCode.Algorithms.CompareVersionNumbers;

/// <summary>
///     https://leetcode.com/problems/compare-version-numbers/
/// </summary>
public interface ICompareVersionNumbers
{
    /// <summary>
    ///     Compares <paramref name="version1" /> and <paramref name="version2" /> by their dot-separated revision values.
    /// </summary>
    /// <param name="version1">The first version string.</param>
    /// <param name="version2">The second version string.</param>
    /// <returns>
    ///     -1 if <paramref name="version1" /> is less than <paramref name="version2" />, 1 if it is greater, and 0 if they
    ///     are equal.
    /// </returns>
    int CompareVersion(string version1, string version2);
}