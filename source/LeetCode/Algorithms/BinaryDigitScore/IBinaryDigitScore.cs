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

namespace LeetCode.Algorithms.BinaryDigitScore;

/// <summary>
///     https://leetcode.com/problems/binary-digit-score/description/
/// </summary>
public interface IBinaryDigitScore
{
    /// <summary>
    ///     Calculates the score of two integers based on the numbers of set bits in their binary representations: the
    ///     product of the counts when the first count is not less than the second, otherwise the integer quotient of the
    ///     second count divided by the first.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <returns>The score of <paramref name="a" /> and <paramref name="b" />.</returns>
    int CalculateScore(int a, int b);
}