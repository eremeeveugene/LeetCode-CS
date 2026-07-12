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

namespace LeetCode.Algorithms.CheckIfNAndItsDoubleExist;

/// <summary>
///     https://leetcode.com/problems/check-if-n-and-its-double-exist/description/
/// </summary>
public interface ICheckIfNAndItsDoubleExist
{
    /// <summary>
    ///     Determines whether <paramref name="arr" /> contains two distinct indices i and j such that arr[i] is twice
    ///     arr[j].
    /// </summary>
    /// <param name="arr">The array of integers.</param>
    /// <returns><c>true</c> if an element and its double exist at distinct indices; otherwise, <c>false</c>.</returns>
    bool CheckIfExist(int[] arr);
}