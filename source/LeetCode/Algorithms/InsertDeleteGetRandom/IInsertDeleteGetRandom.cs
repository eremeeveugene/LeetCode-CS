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

namespace LeetCode.Algorithms.InsertDeleteGetRandom;

/// <summary>
///     https://leetcode.com/problems/insert-delete-getrandom-o1/description/
/// </summary>
public interface IInsertDeleteGetRandom
{
    /// <summary>
    ///     Inserts <paramref name="value" /> into the set if it is not already present.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    /// <returns><c>true</c> if <paramref name="value" /> was not present and was inserted; otherwise, <c>false</c>.</returns>
    bool Insert(int value);

    /// <summary>
    ///     Removes <paramref name="value" /> from the set if it is present.
    /// </summary>
    /// <param name="value">The value to remove.</param>
    /// <returns><c>true</c> if <paramref name="value" /> was present and was removed; otherwise, <c>false</c>.</returns>
    bool Remove(int value);

    /// <summary>
    ///     Returns a random element from the current set, with each element having an equal probability of being returned.
    /// </summary>
    /// <returns>A random element from the set.</returns>
    int GetRandom();
}