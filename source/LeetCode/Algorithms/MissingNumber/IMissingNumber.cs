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

namespace LeetCode.Algorithms.MissingNumber;

/// <summary>
///     https://leetcode.com/problems/missing-number/description/
/// </summary>
public interface IMissingNumber
{
    /// <summary>
    ///     Finds the one number missing from <paramref name="nums" />, an array containing <c>n</c> distinct numbers
    ///     taken from the range [0, n].
    /// </summary>
    /// <param name="nums">The array of distinct numbers with exactly one number missing from the range [0, n].</param>
    /// <returns>The missing number in the range [0, n].</returns>
    int MissingNumber(int[] nums);
}