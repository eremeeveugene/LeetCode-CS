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

namespace LeetCode.Algorithms.CheckIfArrayIsSortedAndRotated;

/// <summary>
///     https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/description/
/// </summary>
public interface ICheckIfArrayIsSortedAndRotated
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> could have been obtained by rotating an array sorted in
    ///     non-decreasing order.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns><c>true</c> if <paramref name="nums" /> is a rotation of a non-decreasingly sorted array; otherwise, <c>false</c>.</returns>
    bool Check(int[] nums);
}