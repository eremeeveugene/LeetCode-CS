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

namespace LeetCode.Algorithms.MinimumValueOfMergedIntegers;

/// <summary>
///     https://leetcode.com/problems/minimum-value-of-merged-integers/description/
/// </summary>
public interface IMinimumValueOfMergedIntegers
{
    /// <summary>
    ///     Merges consecutive pairs of <paramref name="nums" /> by concatenating their decimal digits and finds the
    ///     smallest resulting integer.
    /// </summary>
    /// <param name="nums">The array of even length whose consecutive pairs are merged.</param>
    /// <returns>The minimum value among the merged integers.</returns>
    int MinMergedInteger(int[] nums);
}