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

namespace LeetCode.Algorithms.CanMakeArithmeticProgressionFromSequence;

/// <summary>
///     https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/
/// </summary>
public interface ICanMakeArithmeticProgressionFromSequence
{
    /// <summary>
    ///     Determines whether the elements of <paramref name="arr" /> can be rearranged to form an arithmetic progression.
    /// </summary>
    /// <param name="arr">The array of numbers to check.</param>
    /// <returns><c>true</c> if <paramref name="arr" /> can be rearranged into an arithmetic progression; otherwise, <c>false</c>.</returns>
    bool CanMakeArithmeticProgression(int[] arr);
}