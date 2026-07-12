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

namespace LeetCode.Algorithms.DesignHashMap;

/// <summary>
///     https://leetcode.com/problems/design-hashmap/description/
/// </summary>
public interface IDesignHashMap
{
    /// <summary>
    ///     Inserts or updates the mapping of <paramref name="key" /> to <paramref name="value" />.
    /// </summary>
    /// <param name="key">The key to insert or update.</param>
    /// <param name="value">The value to associate with <paramref name="key" />.</param>
    void Put(int key, int value);

    /// <summary>
    ///     Retrieves the value associated with <paramref name="key" />.
    /// </summary>
    /// <param name="key">The key whose value is retrieved.</param>
    /// <returns>The value associated with <paramref name="key" />, or -1 if the key does not exist.</returns>
    int Get(int key);

    /// <summary>
    ///     Removes the mapping for <paramref name="key" /> if it exists.
    /// </summary>
    /// <param name="key">The key whose mapping is removed.</param>
    void Remove(int key);
}