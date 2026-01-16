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

namespace LeetCode.Algorithms.SplitStringsBySeparator;

/// <inheritdoc />
public sealed class SplitStringsBySeparatorStringSplit : ISplitStringsBySeparator
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="words"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
    {
        var result = new List<string>();

        foreach (var word in words)
        {
            result.AddRange(word.Split(separator, StringSplitOptions.RemoveEmptyEntries));
        }

        return result;
    }
}