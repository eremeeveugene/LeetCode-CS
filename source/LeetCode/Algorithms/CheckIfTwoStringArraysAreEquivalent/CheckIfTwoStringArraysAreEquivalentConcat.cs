// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class CheckIfTwoStringArraysAreEquivalentConcat : ICheckIfTwoStringArraysAreEquivalent
{
    /// <summary>
    ///     Time complexity - O(n + m)
    /// </summary>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    /// <returns></returns>
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        return string.Concat(word1).Equals(string.Concat(word2));
    }
}