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

namespace LeetCode.Algorithms.CrawlerLogFolder;

/// <summary>
///     https://leetcode.com/problems/crawler-log-folder/description/
/// </summary>
public interface ICrawlerLogFolder
{
    /// <summary>
    ///     Computes the minimum number of operations needed to go back to the main folder after performing the change
    ///     folder operations described in <paramref name="logs" />.
    /// </summary>
    /// <param name="logs">The list of change folder operations performed by the file system.</param>
    /// <returns>The minimum number of operations needed to return to the main folder.</returns>
    int MinOperations(string[] logs);
}