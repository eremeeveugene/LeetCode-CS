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

namespace LeetCode.Algorithms.ShuffleTheArray;

/// <summary>
///     https://leetcode.com/problems/shuffle-the-array/
/// </summary>
public interface IShuffleTheArray
{
    /// <summary>
    ///     Unshuffles <paramref name="nums" />, which is formatted as [x1, x2, ..., xn, y1, y2, ..., yn], into
    ///     the interleaved sequence [x1, y1, x2, y2, ..., xn, yn].
    /// </summary>
    /// <param name="nums">The concatenated array of x and y values to interleave.</param>
    /// <param name="n">The number of x values (and y values) in <paramref name="nums" />.</param>
    /// <returns>The interleaved array [x1, y1, x2, y2, ..., xn, yn].</returns>
    int[] Shuffle(int[] nums, int n);
}