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

namespace LeetCode.Algorithms.MaximumOddBinaryNumber;

/// <summary>
///     https://leetcode.com/problems/maximum-odd-binary-number/description/
/// </summary>
public interface IMaximumOddBinaryNumber
{
    /// <summary>
    ///     Rearranges the bits of the binary string <paramref name="s" /> to form the maximum possible odd binary
    ///     number.
    /// </summary>
    /// <param name="s">The binary string, containing at least one '1', to rearrange.</param>
    /// <returns>The maximum odd binary number obtainable by rearranging the bits of <paramref name="s" />.</returns>
    string MaximumOddBinaryNumber(string s);
}