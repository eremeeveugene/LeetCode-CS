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

namespace LeetCode.Algorithms.DesignLinkedList;

/// <summary>
///     https://leetcode.com/problems/design-linked-list/description/
/// </summary>
public interface IDesignLinkedList
{
    /// <summary>
    ///     Gets the value at a zero-based index, or -1 if the index is outside the list.
    /// </summary>
    /// <param name="index">The nonnegative index to read.</param>
    /// <returns>The node value, or -1 if the index is invalid.</returns>
    int Get(int index);

    /// <summary>
    ///     Inserts a value before the first node.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    void AddAtHead(int value);

    /// <summary>
    ///     Appends a value after the last node.
    /// </summary>
    /// <param name="value">The value to append.</param>
    void AddAtTail(int value);

    /// <summary>
    ///     Inserts a value before the given index, appends at the list length, or does nothing if the index exceeds it.
    /// </summary>
    /// <param name="index">The nonnegative insertion index.</param>
    /// <param name="value">The value to insert.</param>
    void AddAtIndex(int index, int value);

    /// <summary>
    ///     Removes the node at the given index if it exists.
    /// </summary>
    /// <param name="index">The nonnegative index to delete.</param>
    void DeleteAtIndex(int index);
}