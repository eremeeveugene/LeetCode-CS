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

namespace LeetCode.Algorithms.FaultyKeyboard;

/// <summary>
///     https://leetcode.com/problems/faulty-keyboard/
/// </summary>
public interface IFaultyKeyboard
{
    /// <summary>
    ///     Returns the string that appears on the screen after typing <paramref name="s" /> on a faulty keyboard that
    ///     reverses the written text whenever the character 'i' is typed.
    /// </summary>
    /// <param name="s">The string typed on the faulty keyboard.</param>
    /// <returns>The final string shown on the screen.</returns>
    string FinalString(string s);
}