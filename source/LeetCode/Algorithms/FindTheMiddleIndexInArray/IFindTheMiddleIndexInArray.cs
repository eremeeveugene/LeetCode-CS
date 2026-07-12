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

namespace LeetCode.Algorithms.FindTheMiddleIndexInArray;

/// <summary>
///     https://leetcode.com/problems/find-the-middle-index-in-array/
/// </summary>
public interface IFindTheMiddleIndexInArray
{
    /// <summary>
    ///     Finds the leftmost middle index of <paramref name="nums" />, i.e. the index where the sum of the elements to its
    ///     left equals the sum of the elements to its right.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The leftmost middle index, or -1 if no such index exists.</returns>
    int FindMiddleIndex(int[] nums);
}