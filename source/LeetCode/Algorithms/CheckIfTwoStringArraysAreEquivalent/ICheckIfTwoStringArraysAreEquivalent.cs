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

namespace LeetCode.Algorithms.CheckIfTwoStringArraysAreEquivalent;

/// <summary>
///     https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
/// </summary>
public interface ICheckIfTwoStringArraysAreEquivalent
{
    /// <summary>
    ///     Determines whether <paramref name="word1" /> and <paramref name="word2" /> represent the same string when their
    ///     elements are concatenated in order.
    /// </summary>
    /// <param name="word1">The first array of strings.</param>
    /// <param name="word2">The second array of strings.</param>
    /// <returns><c>true</c> if both arrays represent the same string; otherwise, <c>false</c>.</returns>
    bool ArrayStringsAreEqual(string[] word1, string[] word2);
}