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

namespace LeetCode.Algorithms.NumberOfLaserBeamsInABank;

/// <summary>
///     https://leetcode.com/problems/number-of-laser-beams-in-a-bank/description/
/// </summary>
public interface INumberOfLaserBeamsInABank
{
    /// <summary>
    ///     Counts the total number of laser beams in the bank described by <paramref name="bank" />. A beam connects two
    ///     security devices (cells equal to <c>'1'</c>) on different rows when every row strictly between them contains no
    ///     security devices.
    /// </summary>
    /// <param name="bank">
    ///     The floor plan as a binary string array, where <c>bank[i]</c> is the <c>i</c>th row and each character is
    ///     <c>'0'</c> (no device) or <c>'1'</c> (one device).
    /// </param>
    /// <returns>The total number of laser beams in the bank.</returns>
    int NumberOfBeams(string[] bank);
}