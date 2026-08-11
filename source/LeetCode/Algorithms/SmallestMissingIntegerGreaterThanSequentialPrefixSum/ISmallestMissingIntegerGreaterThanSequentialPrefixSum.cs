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

namespace LeetCode.Algorithms.SmallestMissingIntegerGreaterThanSequentialPrefixSum;

/// <summary>
///     https://leetcode.com/problems/smallest-missing-integer-greater-than-sequential-prefix-sum/description/
/// </summary>
public interface ISmallestMissingIntegerGreaterThanSequentialPrefixSum
{
    /// <summary>
    ///     Determines the smallest integer missing from <paramref name="nums" /> that is greater than or equal to
    ///     the sum of the longest sequential prefix of <paramref name="nums" />, where a sequential prefix is one
    ///     in which each element is exactly one more than the previous.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>The smallest missing integer satisfying the condition.</returns>
    int MissingInteger(int[] nums);
}