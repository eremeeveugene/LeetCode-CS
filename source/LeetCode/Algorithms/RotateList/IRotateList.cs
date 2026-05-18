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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.RotateList;

/// <summary>
///     https://leetcode.com/problems/rotate-list/description/
/// </summary>
public interface IRotateList
{
    /// <summary>
    ///     Rotates the linked list to the right by the specified number of positions.
    /// </summary>
    /// <param name="head">The head node of the linked list to rotate.</param>
    /// <param name="k">The number of positions to rotate the linked list to the right.</param>
    /// <returns>The head node of the rotated linked list.</returns>
    ListNode? RotateRight(ListNode? head, int k);
}