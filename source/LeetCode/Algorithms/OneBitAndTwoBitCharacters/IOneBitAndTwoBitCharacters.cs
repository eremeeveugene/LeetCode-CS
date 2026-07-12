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

namespace LeetCode.Algorithms.OneBitAndTwoBitCharacters;

/// <summary>
///     https://leetcode.com/problems/1-bit-and-2-bit-characters/description/
/// </summary>
public interface IOneBitAndTwoBitCharacters
{
    /// <summary>
    ///     Determines whether the last character encoded by <paramref name="bits" /> must be a one-bit character,
    ///     given that the array is decoded into characters represented either by a single 0 bit or by a 1 followed
    ///     by either 0 or 1.
    /// </summary>
    /// <param name="bits">The binary array ending in 0, representing an encoded sequence of characters.</param>
    /// <returns><see langword="true" /> if the last character must be a one-bit character; otherwise, <see langword="false" />.</returns>
    bool IsOneBitCharacter(int[] bits);
}