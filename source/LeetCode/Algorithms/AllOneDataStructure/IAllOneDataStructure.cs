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

namespace LeetCode.Algorithms.AllOneDataStructure;

/// <summary>
///     https://leetcode.com/problems/all-oone-data-structure/description/
/// </summary>
public interface IAllOneDataStructure
{
    /// <summary>
    ///     Increments the count of <paramref name="key" /> by 1, inserting it with count 1 if it does not exist.
    /// </summary>
    /// <param name="key">The key whose count is incremented.</param>
    void Inc(string key);

    /// <summary>
    ///     Decrements the count of the existing <paramref name="key" /> by 1, removing it if its count becomes 0.
    /// </summary>
    /// <param name="key">The key whose count is decremented.</param>
    void Dec(string key);

    /// <summary>
    ///     Returns one of the keys with the maximum count.
    /// </summary>
    /// <returns>A key with the maximum count, or an empty string if no keys exist.</returns>
    string GetMaxKey();

    /// <summary>
    ///     Returns one of the keys with the minimum count.
    /// </summary>
    /// <returns>A key with the minimum count, or an empty string if no keys exist.</returns>
    string GetMinKey();
}