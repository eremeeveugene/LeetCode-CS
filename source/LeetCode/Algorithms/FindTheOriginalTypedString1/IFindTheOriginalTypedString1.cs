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

namespace LeetCode.Algorithms.FindTheOriginalTypedString1;

/// <summary>
///     https://leetcode.com/problems/find-the-original-typed-string-i/description/
/// </summary>
public interface IFindTheOriginalTypedString1
{
    /// <summary>
    ///     Counts the number of possible original strings that could have produced <paramref name="word" />, given that some characters may have been typed with a long press causing consecutive duplicate characters.
    /// </summary>
    /// <param name="word">The final typed string to analyze.</param>
    /// <returns>The number of possible original strings.</returns>
    int PossibleStringCount(string word);
}