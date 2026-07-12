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

namespace LeetCode.Algorithms.DefuseTheBomb;

/// <summary>
///     https://leetcode.com/problems/defuse-the-bomb/description/
/// </summary>
public interface IDefuseTheBomb
{
    /// <summary>
    ///     Decrypts the circular array <paramref name="code" /> by replacing every element with the sum of the next
    ///     <paramref name="k" /> elements if <paramref name="k" /> is positive, the sum of the previous
    ///     <paramref name="k" /> elements if negative, or zero if <paramref name="k" /> is zero.
    /// </summary>
    /// <param name="code">The circular array to decrypt.</param>
    /// <param name="k">The number of adjacent elements to sum for each position.</param>
    /// <returns>The decrypted array.</returns>
    int[] Decrypt(int[] code, int k);
}