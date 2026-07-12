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

namespace LeetCode.Algorithms.FindAllDuplicatesInAnArray;

/// <summary>
///     https://leetcode.com/problems/find-all-duplicates-in-an-array/
/// </summary>
public interface IFindAllDuplicatesInAnArray
{
    /// <summary>
    ///     Finds all integers that appear exactly twice in <paramref name="nums" />, where each element is in the range
    ///     [1, n] and n is the length of the array.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The list of integers that appear exactly twice in the array.</returns>
    IList<int> FindDuplicates(int[] nums);
}