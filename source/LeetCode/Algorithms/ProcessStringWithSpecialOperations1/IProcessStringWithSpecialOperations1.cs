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

namespace LeetCode.Algorithms.ProcessStringWithSpecialOperations1;

/// <summary>
///     https://leetcode.com/problems/process-string-with-special-operations-i/
/// </summary>
public interface IProcessStringWithSpecialOperations1
{
    /// <summary>
    ///     Builds a new string by processing each character of <paramref name="s" /> in order: a lowercase English letter
    ///     is appended to the result, <c>'*'</c> removes the last character from the result if one exists, <c>'#'</c>
    ///     duplicates the result (<c>result = result + result</c>), and <c>'%'</c> reverses the result.
    /// </summary>
    /// <param name="s">The string of lowercase English letters and the special characters <c>'*'</c>, <c>'#'</c>, <c>'%'</c>.</param>
    /// <returns>The final string after all characters of <paramref name="s" /> have been processed.</returns>
    string ProcessStr(string s);
}