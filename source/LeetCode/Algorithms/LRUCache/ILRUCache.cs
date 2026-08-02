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

namespace LeetCode.Algorithms.LRUCache;

/// <summary>
///     https://leetcode.com/problems/lru-cache/description/
/// </summary>
public interface ILRUCache
{
    /// <summary>
    ///     Returns the value associated with <paramref name="key" /> if present, marking it as the most recently
    ///     used entry.
    /// </summary>
    /// <param name="key">The key to look up.</param>
    /// <returns>The value associated with <paramref name="key" />, or <c>-1</c> if the key is not present.</returns>
    int Get(int key);

    /// <summary>
    ///     Inserts or updates the value associated with <paramref name="key" />, marking it as the most recently
    ///     used entry. If the cache is at capacity and <paramref name="key" /> is not already present, evicts the
    ///     least recently used entry first.
    /// </summary>
    /// <param name="key">The key to insert or update.</param>
    /// <param name="value">The value to associate with <paramref name="key" />.</param>
    void Put(int key, int value);
}