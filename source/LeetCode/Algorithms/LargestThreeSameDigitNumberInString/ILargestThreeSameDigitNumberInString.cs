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

namespace LeetCode.Algorithms.LargestThreeSameDigitNumberInString;

/// <summary>
///     https://leetcode.com/problems/largest-3-same-digit-number-in-string/description/
/// </summary>
public interface ILargestThreeSameDigitNumberInString
{
    /// <summary>
    ///     Finds the largest good integer in <paramref name="num" />, where a good integer is a substring of length three
    ///     consisting of a single repeated digit.
    /// </summary>
    /// <param name="num">The string of digits to search.</param>
    /// <returns>The largest good integer as a string, or an empty string if no good integer exists.</returns>
    string LargestGoodInteger(string num);
}