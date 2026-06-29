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

namespace LeetCode.Algorithms.NumberOfStringsThatAppearAsSubstringsInWord;

/// <inheritdoc />
public sealed class NumberOfStringsThatAppearAsSubstringsInWordIterative : INumberOfStringsThatAppearAsSubstringsInWord
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n * k), where m is the number of patterns, n is the length of the word, and k is the maximum pattern length.
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumOfStrings(string[] patterns, string word)
    {
        var result = 0;

        var n = patterns.Length;

        for (var i = 0; i < n; i++)
        {
            var pattern = patterns[i];

            if (word.Contains(pattern))
            {
                result++;
            }
        }

        return result;
    }
}