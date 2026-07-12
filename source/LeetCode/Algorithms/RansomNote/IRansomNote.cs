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

namespace LeetCode.Algorithms.RansomNote;

/// <summary>
///     https://leetcode.com/problems/ransom-note/
/// </summary>
public interface IRansomNote
{
    /// <summary>
    ///     Determines whether <paramref name="ransomNote" /> can be constructed by using letters exclusively from
    ///     <paramref name="magazine" />, where each letter in <paramref name="magazine" /> can be used at most once.
    /// </summary>
    /// <param name="ransomNote">The string to construct.</param>
    /// <param name="magazine">The string supplying the available letters.</param>
    /// <returns><see langword="true" /> if <paramref name="ransomNote" /> can be constructed; otherwise, <see langword="false" />.</returns>
    bool CanConstruct(string ransomNote, string magazine);
}