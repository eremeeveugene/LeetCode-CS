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

namespace LeetCode.Algorithms.DesignNumberContainerSystem;

/// <summary>
///     https://leetcode.com/problems/design-a-number-container-system/description/
/// </summary>
public interface IDesignNumberContainerSystem
{
    /// <summary>
    ///     Inserts or replaces the number at the given index in the container system.
    /// </summary>
    /// <param name="index">The index at which to insert or replace the number.</param>
    /// <param name="number">The number to store at <paramref name="index" />.</param>
    void Change(int index, int number);

    /// <summary>
    ///     Finds the smallest index that is filled with <paramref name="number" />.
    /// </summary>
    /// <param name="number">The number to search for.</param>
    /// <returns>The smallest index filled with <paramref name="number" />, or -1 if no such index exists.</returns>
    int Find(int number);
}