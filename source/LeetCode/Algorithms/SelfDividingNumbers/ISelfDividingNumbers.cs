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

namespace LeetCode.Algorithms.SelfDividingNumbers;

/// <summary>
///     https://leetcode.com/problems/self-dividing-numbers/description/
/// </summary>
public interface ISelfDividingNumbers
{
    /// <summary>
    ///     Finds all self-dividing numbers in the inclusive range from <paramref name="left" /> to
    ///     <paramref name="right" />, where a self-dividing number is divisible by every digit it contains.
    /// </summary>
    /// <param name="left">The lower bound of the range, inclusive.</param>
    /// <param name="right">The upper bound of the range, inclusive.</param>
    /// <returns>A list of all self-dividing numbers between <paramref name="left" /> and <paramref name="right" />.</returns>
    IList<int> SelfDividingNumbers(int left, int right);
}