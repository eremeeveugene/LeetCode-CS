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

namespace LeetCode.Algorithms.DesignBrowserHistory;

/// <summary>
///     https://leetcode.com/problems/design-browser-history/description/
/// </summary>
public interface IDesignBrowserHistory
{
    /// <summary>
    ///     Visits <paramref name="url" /> from the current page, clearing all forward history.
    /// </summary>
    /// <param name="url">The URL to visit.</param>
    void Visit(string url);

    /// <summary>
    ///     Moves up to <paramref name="steps" /> steps back in the browser history.
    /// </summary>
    /// <param name="steps">The number of steps to move back.</param>
    /// <returns>The URL of the current page after moving back at most <paramref name="steps" /> steps.</returns>
    string Back(int steps);

    /// <summary>
    ///     Moves up to <paramref name="steps" /> steps forward in the browser history.
    /// </summary>
    /// <param name="steps">The number of steps to move forward.</param>
    /// <returns>The URL of the current page after moving forward at most <paramref name="steps" /> steps.</returns>
    string Forward(int steps);
}