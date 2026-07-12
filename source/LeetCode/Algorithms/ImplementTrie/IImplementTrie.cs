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

namespace LeetCode.Algorithms.ImplementTrie;

/// <summary>
///     https://leetcode.com/problems/implement-trie-prefix-tree/
/// </summary>
public interface IImplementTrie
{
    /// <summary>
    ///     Inserts <paramref name="word" /> into the trie.
    /// </summary>
    /// <param name="word">The word to insert.</param>
    void Insert(string word);

    /// <summary>
    ///     Determines whether <paramref name="word" /> has been inserted into the trie.
    /// </summary>
    /// <param name="word">The word to search for.</param>
    /// <returns><c>true</c> if <paramref name="word" /> is in the trie; otherwise, <c>false</c>.</returns>
    bool Search(string word);

    /// <summary>
    ///     Determines whether any previously inserted word starts with <paramref name="prefix" />.
    /// </summary>
    /// <param name="prefix">The prefix to search for.</param>
    /// <returns><c>true</c> if an inserted word starts with <paramref name="prefix" />; otherwise, <c>false</c>.</returns>
    bool StartsWith(string prefix);
}