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

namespace LeetCode.Algorithms.MaximumScoreAfterSplittingString;

/// <summary>
///     https://leetcode.com/problems/maximum-score-after-splitting-a-string/description/
/// </summary>
public interface IMaximumScoreAfterSplittingString
{
    /// <summary>
    ///     Splits <paramref name="s" /> into two non-empty substrings and finds the split that maximizes the sum of
    ///     zeros in the left substring and ones in the right substring.
    /// </summary>
    /// <param name="s">The binary string to split.</param>
    /// <returns>The maximum achievable score.</returns>
    int MaxScore(string s);
}