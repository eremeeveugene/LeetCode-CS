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

namespace LeetCode.Algorithms.FindThePrefixCommonArrayOfTwoArrays;

/// <summary>
///     https://leetcode.com/problems/find-the-prefix-common-array-of-two-arrays/description/
/// </summary>
public interface IFindThePrefixCommonArrayOfTwoArrays
{
    /// <summary>
    ///     Finds the prefix common count array for two integer permutations.
    /// </summary>
    /// <param name="a">The first integer permutation.</param>
    /// <param name="b">The second integer permutation.</param>
    /// <returns>The prefix common count array for the two permutations.</returns>
    int[] FindThePrefixCommonArray(int[] a, int[] b);
}