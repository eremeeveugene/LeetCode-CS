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

namespace LeetCode.Algorithms.KeepMultiplyingFoundValuesByTwo;

/// <summary>
///     https://leetcode.com/problems/keep-multiplying-found-values-by-two/description/
/// </summary>
public interface IKeepMultiplyingFoundValuesByTwo
{
    /// <summary>
    ///     Repeatedly doubles <paramref name="original" /> while its current value is found in <paramref name="nums" /> and
    ///     returns the final value.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <param name="original">The starting value to search for and multiply.</param>
    /// <returns>The final value of <paramref name="original" /> once it is no longer found in <paramref name="nums" />.</returns>
    int FindFinalValue(int[] nums, int original);
}