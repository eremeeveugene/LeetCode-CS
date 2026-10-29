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

namespace LeetCode.Algorithms.MinimumDeletionsForKMostKDistinctCharacters;

/// <inheritdoc />
public abstract class MinimumDeletionsForKMostKDistinctCharactersBase : IMinimumDeletionsForKMostKDistinctCharacters
{
    /// <inheritdoc />
    public abstract int MinDeletion(string s, int k);

    /// <summary>
    ///     Counts the occurrences of each lowercase English letter in <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string of lowercase English letters.</param>
    /// <returns>The array of letter frequencies, indexed by <c>c - 'a'</c>.</returns>
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of <paramref name="s" />
    ///     Space complexity - O(1)
    /// </remarks>
    protected static int[] GetFrequencyArray(string s)
    {
        var frequencyArray = new int['z' - 'a' + 1];

        var n = s.Length;

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            frequencyArray[c - 'a']++;
        }

        return frequencyArray;
    }

    /// <summary>
    ///     Counts the letters that occur at least once.
    /// </summary>
    /// <param name="frequencyArray">The array of letter frequencies.</param>
    /// <returns>The number of distinct letters.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected static int GetDistinctCount(int[] frequencyArray)
    {
        var distinctCount = 0;

        var n = frequencyArray.Length;

        for (var i = 0; i < n; i++)
        {
            if (frequencyArray[i] > 0)
            {
                distinctCount++;
            }
        }

        return distinctCount;
    }
}