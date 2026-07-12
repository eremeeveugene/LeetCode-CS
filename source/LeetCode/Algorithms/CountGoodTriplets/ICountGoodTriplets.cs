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

namespace LeetCode.Algorithms.CountGoodTriplets;

/// <summary>
///     https://leetcode.com/problems/count-good-triplets/description/
/// </summary>
public interface ICountGoodTriplets
{
    /// <summary>
    ///     Counts the triplets (i, j, k) with i &lt; j &lt; k such that |<paramref name="arr" />[i] -
    ///     <paramref name="arr" />[j]| &lt;= <paramref name="a" />, |<paramref name="arr" />[j] -
    ///     <paramref name="arr" />[k]| &lt;= <paramref name="b" /> and |<paramref name="arr" />[i] -
    ///     <paramref name="arr" />[k]| &lt;= <paramref name="c" />.
    /// </summary>
    /// <param name="arr">The array of integers.</param>
    /// <param name="a">The maximum allowed absolute difference between the first and second elements.</param>
    /// <param name="b">The maximum allowed absolute difference between the second and third elements.</param>
    /// <param name="c">The maximum allowed absolute difference between the first and third elements.</param>
    /// <returns>The number of good triplets.</returns>
    int CountGoodTriplets(int[] arr, int a, int b, int c);
}