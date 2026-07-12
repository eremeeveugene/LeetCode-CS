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

namespace LeetCode.Algorithms.LargestEvenNumber;

/// <summary>
///     https://leetcode.com/problems/largest-even-number/description/
/// </summary>
public interface ILargestEvenNumber
{
    /// <summary>
    ///     Finds the largest even number that can be formed by rearranging the digits of <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string of digits to rearrange.</param>
    /// <returns>The largest even number that can be formed, or an empty string if no even number can be formed.</returns>
    string LargestEven(string s);
}