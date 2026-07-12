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

namespace LeetCode.Algorithms.FindTheEncryptedString;

/// <summary>
///     https://leetcode.com/problems/find-the-encrypted-string/description/
/// </summary>
public interface IFindTheEncryptedString
{
    /// <summary>
    ///     Encrypts <paramref name="s" /> by replacing each character with the character <paramref name="k" /> positions
    ///     after it in the string, in a cyclic manner.
    /// </summary>
    /// <param name="s">The string to encrypt.</param>
    /// <param name="k">The cyclic shift applied to each character position.</param>
    /// <returns>The encrypted string.</returns>
    string GetEncryptedString(string s, int k);
}