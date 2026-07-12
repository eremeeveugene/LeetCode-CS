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

namespace LeetCode.Algorithms.CheckIfNumberIsSumOfPowersOfThree;

/// <summary>
///     https://leetcode.com/problems/check-if-number-is-a-sum-of-powers-of-three/description/
/// </summary>
public interface ICheckIfNumberIsSumOfPowersOfThree
{
    /// <summary>
    ///     Determines whether <paramref name="n" /> can be represented as a sum of distinct powers of three.
    /// </summary>
    /// <param name="n">The number to check.</param>
    /// <returns><c>true</c> if <paramref name="n" /> is a sum of distinct powers of three; otherwise, <c>false</c>.</returns>
    bool CheckPowersOfThree(int n);
}