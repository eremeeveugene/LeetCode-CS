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

namespace LeetCode.Algorithms.MinimumNumberOfChangesToMakeBinaryStringBeautiful;

/// <inheritdoc />
public sealed class MinimumNumberOfChangesToMakeBinaryStringBeautifulGreedy : IMinimumNumberOfChangesToMakeBinaryStringBeautiful
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MinChanges(string s)
    {
        var result = 0;

        for (var i = 0; i < s.Length - 1; i += 2)
        {
            if (s[i] != s[i + 1])
            {
                result++;
            }
        }

        return result;
    }
}