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

namespace LeetCode.Algorithms.LargestNumber;

/// <summary>
///     https://leetcode.com/problems/largest-number/
/// </summary>
public interface ILargestNumber
{
    /// <summary>
    ///     Arranges the elements of <paramref name="nums" /> so that their concatenation forms the largest possible number.
    /// </summary>
    /// <param name="nums">The array of non-negative integers.</param>
    /// <returns>The largest number that can be formed by concatenating the elements, as a string.</returns>
    string LargestNumber(int[] nums);
}