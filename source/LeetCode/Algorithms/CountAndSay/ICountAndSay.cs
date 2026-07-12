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

namespace LeetCode.Algorithms.CountAndSay;

/// <summary>
///     https://leetcode.com/problems/count-and-say/description/
/// </summary>
public interface ICountAndSay
{
    /// <summary>
    ///     Returns the <paramref name="n" />-th element of the count-and-say sequence, where each element is the run-length
    ///     encoding of the previous element.
    /// </summary>
    /// <param name="n">The 1-based index of the count-and-say sequence element.</param>
    /// <returns>The <paramref name="n" />-th element of the count-and-say sequence.</returns>
    string CountAndSay(int n);
}