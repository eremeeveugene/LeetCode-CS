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

namespace LeetCode.Algorithms.CheckIfArrayIsGood;

/// <summary>
///     https://leetcode.com/problems/check-if-array-is-good/description/
/// </summary>
public interface ICheckIfArrayIsGood
{
    /// <summary>
    ///     Determines whether the array is good.
    /// </summary>
    /// <param name="nums">The integer array that should be checked.</param>
    /// <returns><see langword="true" /> if the array is good; otherwise, <see langword="false" />.</returns>
    bool IsGood(int[] nums);
}