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

namespace LeetCode.Algorithms.MaxConsecutiveOnes;

/// <summary>
///     https://leetcode.com/problems/max-consecutive-ones/description/
/// </summary>
public interface IMaxConsecutiveOnes
{
    /// <summary>
    ///     Finds the maximum number of consecutive 1s in the binary array <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The binary array to scan for consecutive 1s.</param>
    /// <returns>The maximum count of consecutive 1s found in <paramref name="nums" />.</returns>
    int FindMaxConsecutiveOnes(int[] nums);
}