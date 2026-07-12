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

namespace LeetCode.Algorithms.DesignHashSet;

/// <summary>
///     https://leetcode.com/problems/design-hashset/description/
/// </summary>
public interface IDesignHashSet
{
    /// <summary>
    ///     Inserts <paramref name="key" /> into the set if it is not already present.
    /// </summary>
    /// <param name="key">The value to insert.</param>
    void Add(int key);

    /// <summary>
    ///     Removes <paramref name="key" /> from the set if it exists.
    /// </summary>
    /// <param name="key">The value to remove.</param>
    void Remove(int key);

    /// <summary>
    ///     Determines whether <paramref name="key" /> exists in the set.
    /// </summary>
    /// <param name="key">The value to check for.</param>
    /// <returns><see langword="true" /> if <paramref name="key" /> exists in the set; otherwise, <see langword="false" />.</returns>
    bool Contains(int key);
}