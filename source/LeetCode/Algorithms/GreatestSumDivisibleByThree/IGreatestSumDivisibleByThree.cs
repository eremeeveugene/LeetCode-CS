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

namespace LeetCode.Algorithms.GreatestSumDivisibleByThree;

/// <summary>
///     https://leetcode.com/problems/greatest-sum-divisible-by-three/description/
/// </summary>
public interface IGreatestSumDivisibleByThree
{
    /// <summary>
    ///     Finds the maximum possible sum of elements of <paramref name="nums" /> such that the sum is divisible by three.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The maximum sum of elements that is divisible by three.</returns>
    int MaxSumDivThree(int[] nums);
}