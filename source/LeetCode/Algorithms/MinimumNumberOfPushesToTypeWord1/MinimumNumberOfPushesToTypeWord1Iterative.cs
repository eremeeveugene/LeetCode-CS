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

namespace LeetCode.Algorithms.MinimumNumberOfPushesToTypeWord1;

/// <inheritdoc />
public sealed class MinimumNumberOfPushesToTypeWord1Iterative : IMinimumNumberOfPushesToTypeWord1
{
    private const int KeysCount = 8;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of word
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinimumPushes(string word)
    {
        var n = word.Length;

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            result += (i / KeysCount) + 1;
        }

        return result;
    }
}