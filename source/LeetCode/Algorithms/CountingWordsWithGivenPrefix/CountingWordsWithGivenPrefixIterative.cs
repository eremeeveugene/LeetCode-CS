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

namespace LeetCode.Algorithms.CountingWordsWithGivenPrefix;

/// <inheritdoc />
public sealed class CountingWordsWithGivenPrefixIterative : ICountingWordsWithGivenPrefix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m), where n is the number of words and m is the length of the prefix pref
    ///     Space complexity - O(1)
    /// </remarks>
    public int PrefixCount(string[] words, string pref)
    {
        return words.Count(word => word.StartsWith(pref));
    }
}