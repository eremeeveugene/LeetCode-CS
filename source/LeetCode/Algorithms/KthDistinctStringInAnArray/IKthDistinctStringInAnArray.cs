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

namespace LeetCode.Algorithms.KthDistinctStringInAnArray;

/// <summary>
///     https://leetcode.com/problems/kth-distinct-string-in-an-array/
/// </summary>
public interface IKthDistinctStringInAnArray
{
    /// <summary>
    ///     Finds the <paramref name="k" />-th distinct string present in <paramref name="arr" /> in order of appearance.
    /// </summary>
    /// <param name="arr">The array of strings.</param>
    /// <param name="k">The 1-based position of the distinct string to find.</param>
    /// <returns>The <paramref name="k" />-th distinct string, or an empty string if there are fewer than <paramref name="k" /> distinct strings.</returns>
    string KthDistinct(string[] arr, int k);
}