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

namespace LeetCode.Algorithms.FindTheLexicographicallySmallestValidSequence;

/// <inheritdoc />
public sealed class FindTheLexicographicallySmallestValidSequenceGreedy : IFindTheLexicographicallySmallestValidSequence
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] ValidSequence(string word1, string word2)
    {
        var n = word1.Length;

        Span<int> matchableSuffixLength = stackalloc int[n + 1];

        ComputeMatchableSuffixLengths(word1, word2, matchableSuffixLength);

        return BuildSequence(word1, word2, matchableSuffixLength);
    }

    /// <summary>
    ///     Fills <paramref name="matchableSuffixLength" /> so that <c>matchableSuffixLength[i]</c> holds the length
    ///     of the longest suffix of <paramref name="word2" /> that is a subsequence of <paramref name="word1" />
    ///     starting from index <c>i</c> onward.
    /// </summary>
    /// <param name="word1">The string to select indices from.</param>
    /// <param name="word2">The target string.</param>
    /// <param name="matchableSuffixLength">
    ///     The output span of length <c>word1.Length + 1</c> to fill; <c>matchableSuffixLength[word1.Length]</c> is
    ///     always <c>0</c>.
    /// </param>
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of word1
    ///     Space complexity - O(1)
    /// </remarks>
    private static void ComputeMatchableSuffixLengths(string word1, string word2, Span<int> matchableSuffixLength)
    {
        var n = word1.Length;
        var m = word2.Length;

        for (var i = n - 1; i >= 0; i--)
        {
            var currentLength = matchableSuffixLength[i + 1];

            if (currentLength < m && word1[i] == word2[m - currentLength - 1])
            {
                currentLength++;
            }

            matchableSuffixLength[i] = currentLength;
        }
    }

    /// <summary>
    ///     Greedily selects, for each character of <paramref name="word2" /> in order, the smallest available index
    ///     into <paramref name="word1" /> that either matches exactly or spends the single allowed substitution.
    ///     <paramref name="matchableSuffixLength" /> confirms the remainder of <paramref name="word2" /> can still
    ///     be completed before the substitution is spent.
    /// </summary>
    /// <param name="word1">The string to select indices from.</param>
    /// <param name="word2">The target string the selected characters must almost equal.</param>
    /// <param name="matchableSuffixLength">The precomputed span from <see cref="ComputeMatchableSuffixLengths" />.</param>
    /// <returns>
    ///     The lexicographically smallest valid sequence of indices, or an empty array if no valid sequence exists.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of word1
    ///     Space complexity - O(m), where m is the length of word2
    /// </remarks>
    private static int[] BuildSequence(string word1, string word2, Span<int> matchableSuffixLength)
    {
        var n = word1.Length;
        var m = word2.Length;

        var sequence = new int[m];

        var wordIndex = 0;
        var usedSubstitution = false;

        for (var i = 0; i < n && wordIndex < m; i++)
        {
            var character = word1[i];

            if (character == word2[wordIndex])
            {
                sequence[wordIndex] = i;

                wordIndex++;
            }
            else if (!usedSubstitution && matchableSuffixLength[i + 1] >= m - wordIndex - 1)
            {
                sequence[wordIndex] = i;

                wordIndex++;

                usedSubstitution = true;
            }
        }

        return wordIndex == m ? sequence : [];
    }
}