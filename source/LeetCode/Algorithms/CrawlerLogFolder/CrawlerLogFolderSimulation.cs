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

/// <inheritdoc />
public sealed class CrawlerLogFolderSimulation : ICrawlerLogFolder
{
    private const string MoveToParent = "../";
    private const string Remain = "./";

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinOperations(string[] logs)
    {
        var depth = 0;

        foreach (var log in logs)
        {
            switch (log)
            {
                case MoveToParent:
                    depth = Math.Max(0, depth - 1);
                    break;
                case Remain:
                    break;
                default:
                    depth++;
                    break;
            }
        }

        return depth;
    }
}