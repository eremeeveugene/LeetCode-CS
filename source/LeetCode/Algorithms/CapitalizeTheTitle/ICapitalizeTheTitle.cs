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

namespace LeetCode.Algorithms.CapitalizeTheTitle;

/// <summary>
///     https://leetcode.com/problems/capitalize-the-title/
/// </summary>
public interface ICapitalizeTheTitle
{
    /// <summary>
    ///     Capitalizes the title so that words of one or two letters are fully lowercase and longer words start with an
    ///     uppercase letter followed by lowercase letters.
    /// </summary>
    /// <param name="title">The title consisting of words separated by single spaces.</param>
    /// <returns>The capitalized title.</returns>
    string CapitalizeTitle(string title);
}