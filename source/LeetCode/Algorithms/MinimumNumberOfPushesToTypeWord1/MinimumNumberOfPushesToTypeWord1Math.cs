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
public sealed class MinimumNumberOfPushesToTypeWord1Math : IMinimumNumberOfPushesToTypeWord1
{
    private const int KeysCount = 8;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinimumPushes(string word)
    {
        var n = word.Length;

        var fullKeyRounds = ((n - 1) / KeysCount) + 1;
        var lettersInLastRound = n - ((fullKeyRounds - 1) * KeysCount);

        return (fullKeyRounds * (fullKeyRounds - 1) * 4) + (lettersInLastRound * fullKeyRounds);
    }
}