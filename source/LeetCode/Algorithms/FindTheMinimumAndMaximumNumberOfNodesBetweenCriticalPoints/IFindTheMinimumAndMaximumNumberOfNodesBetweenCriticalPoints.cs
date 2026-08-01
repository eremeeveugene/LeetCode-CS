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

namespace LeetCode.Algorithms.FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints;

/// <summary>
///     https://leetcode.com/problems/find-the-minimum-and-maximum-number-of-nodes-between-critical-points/
/// </summary>
public interface IFindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints
{
    /// <summary>
    ///     Finds the minimum and maximum distances between consecutive critical points (local minima or maxima) in the linked list starting at
    ///     <paramref name="head" />.
    /// </summary>
    /// <param name="head">The head node of the linked list to examine.</param>
    /// <returns>An array containing the minimum and maximum distances between critical points, or <c>[-1, -1]</c> if fewer than two critical points exist.</returns>
    int[] NodesBetweenCriticalPoints(ListNode? head);
}