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

namespace LeetCode.Algorithms.FindAllNumbersDisappearedInArray;

/// <summary>
///     https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
/// </summary>
public interface IFindAllNumbersDisappearedInArray
{
    /// <summary>
    ///     Finds all integers in the range [1, n] that do not appear in <paramref name="nums" />, where n is the length of
    ///     the array.
    /// </summary>
    /// <param name="nums">The array of integers with values in the range [1, n].</param>
    /// <returns>The list of integers in the range [1, n] that are missing from the array.</returns>
    IList<int> FindDisappearedNumbers(int[] nums);
}