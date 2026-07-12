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

namespace LeetCode.Algorithms.LargestCombinationWithBitwiseANDGreaterThanZero;

/// <summary>
///     https://leetcode.com/problems/largest-combination-with-bitwise-and-greater-than-zero/description/
/// </summary>
public interface ILargestCombinationWithBitwiseANDGreaterThanZero
{
    /// <summary>
    ///     Finds the size of the largest combination of elements of <paramref name="candidates" /> whose bitwise AND is
    ///     greater than zero.
    /// </summary>
    /// <param name="candidates">The array of positive integers.</param>
    /// <returns>The size of the largest combination with a bitwise AND greater than zero.</returns>
    int LargestCombination(int[] candidates);
}