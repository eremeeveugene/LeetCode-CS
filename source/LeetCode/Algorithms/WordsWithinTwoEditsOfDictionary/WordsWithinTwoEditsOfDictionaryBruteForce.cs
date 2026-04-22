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

namespace LeetCode.Algorithms.WordsWithinTwoEditsOfDictionary;

/// <inheritdoc />
public sealed class WordsWithinTwoEditsOfDictionaryBruteForce : IWordsWithinTwoEditsOfDictionary
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(q * w * n), where q is the number of queries,
    ///     w is the number of words, and n is the length of each word.
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<string> TwoEditWords(string[] queries, string[] words)
    {
        var result = new List<string>();

        for (var i = 0; i < queries.Length; i++)
        {
            var query = queries[i];

            var isValid = IsValid(query, words);

            if (isValid)
            {
                result.Add(query);
            }
        }

        return result;
    }

    /// <summary>
    ///     Determines whether <paramref name="query" /> can be transformed into any word
    ///     in <paramref name="words" /> by changing at most two characters.
    /// </summary>
    /// <param name="query">The candidate string to validate.</param>
    /// <param name="words">Dictionary of target words with the same length as the query.</param>
    /// <returns>
    ///     <c>true</c> if at least one word in <paramref name="words" /> is within two
    ///     edits of <paramref name="query" />; otherwise, <c>false</c>.
    /// </returns>
    private static bool IsValid(string query, string[] words)
    {
        for (var j = 0; j < words.Length; j++)
        {
            var word = words[j];

            if (IsWithinTwoEdits(query, word))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    ///     Checks whether two equal-length strings differ in at most two positions by
    ///     counting character mismatches and short-circuiting once the limit is exceeded.
    /// </summary>
    /// <param name="query">The candidate string being compared.</param>
    /// <param name="word">The dictionary word being compared against.</param>
    /// <returns>
    ///     <c>true</c> if <paramref name="query" /> and <paramref name="word" /> differ
    ///     in no more than two character positions; otherwise, <c>false</c>.
    /// </returns>
    private static bool IsWithinTwoEdits(string query, string word)
    {
        var differences = 0;

        for (var k = 0; k < query.Length; k++)
        {
            if (query[k] == word[k])
            {
                continue;
            }

            differences++;

            if (differences > 2)
            {
                return false;
            }
        }

        return true;
    }
}