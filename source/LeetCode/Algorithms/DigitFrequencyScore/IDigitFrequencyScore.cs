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

namespace LeetCode.Algorithms.DigitFrequencyScore;

/// <summary>
///     https://leetcode.com/problems/digit-frequency-score/description/
/// </summary>
public interface IDigitFrequencyScore
{
    /// <summary>
    ///     Computes the digit frequency score of an integer, defined as the sum of <c>d * freq(d)</c> over all distinct digits.
    /// </summary>
    /// <param name="n">The positive integer whose digit frequency score should be computed.</param>
    /// <returns>The digit frequency score of <paramref name="n" />.</returns>
    int DigitFrequencyScore(int n);
}