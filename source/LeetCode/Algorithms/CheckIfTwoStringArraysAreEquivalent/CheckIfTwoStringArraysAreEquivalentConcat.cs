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

/// <inheritdoc />
public sealed class CheckIfTwoStringArraysAreEquivalentConcat : ICheckIfTwoStringArraysAreEquivalent
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </remarks>
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        return string.Concat(word1).Equals(string.Concat(word2));
    }
}