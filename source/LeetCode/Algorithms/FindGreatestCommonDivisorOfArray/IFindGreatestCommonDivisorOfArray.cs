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

namespace LeetCode.Algorithms.FindGreatestCommonDivisorOfArray;

/// <summary>
///     https://leetcode.com/problems/find-greatest-common-divisor-of-array/description/
/// </summary>
public interface IFindGreatestCommonDivisorOfArray
{
    /// <summary>
    ///     Finds the greatest common divisor of the smallest and largest numbers in the array.
    /// </summary>
    /// <param name="nums">The array of integers to evaluate.</param>
    /// <returns>The greatest common divisor of the smallest and largest numbers in the array.</returns>
    int FindGCD(int[] nums);
}