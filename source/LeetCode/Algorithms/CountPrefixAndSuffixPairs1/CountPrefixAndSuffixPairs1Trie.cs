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

namespace LeetCode.Algorithms.CountPrefixAndSuffixPairs1;

/// <inheritdoc />
public sealed class CountPrefixAndSuffixPairs1Trie : ICountPrefixAndSuffixPairs1
{
    private readonly Node _prefixRoot = new();
    private readonly Node _suffixRoot = new();

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 * L), where L is the average word length
    ///     Space complexity - O(n * L), where L is the average word length
    /// </remarks>
    public int CountPrefixSuffixPairs(string[] words)
    {
        foreach (var word in words)
        {
            InsertPrefix(word);
            InsertSuffix(word);
        }

        var count = 0;

        for (var i = 0; i < words.Length; i++)
        {
            for (var j = i + 1; j < words.Length; j++)
            {
                if (IsPrefixAndSuffix(words[i], words[j]))
                {
                    count++;
                }
            }
        }

        return count;
    }

    /// <summary>
    ///     Inserts <paramref name="word" /> into the prefix trie, one character at a time from the start.
    /// </summary>
    /// <param name="word">The word to insert.</param>
    private void InsertPrefix(string word)
    {
        var currentNode = _prefixRoot;

        foreach (var c in word)
        {
            if (currentNode.Nodes.TryGetValue(c, out var node))
            {
                currentNode = node;
            }
            else
            {
                currentNode.Nodes[c] = new Node();

                currentNode = currentNode.Nodes[c];
            }
        }
    }

    /// <summary>
    ///     Inserts <paramref name="word" /> into the suffix trie, one character at a time from the end.
    /// </summary>
    /// <param name="word">The word to insert.</param>
    private void InsertSuffix(string word)
    {
        var currentNode = _suffixRoot;

        for (var i = word.Length - 1; i >= 0; i--)
        {
            if (currentNode.Nodes.TryGetValue(word[i], out var node))
            {
                currentNode = node;
            }
            else
            {
                currentNode.Nodes[word[i]] = new Node();

                currentNode = currentNode.Nodes[word[i]];
            }
        }
    }

    /// <summary>
    ///     Determines whether <paramref name="prefixSuffix" /> is both a prefix and a suffix of <paramref name="word" />.
    /// </summary>
    /// <param name="prefixSuffix">The candidate prefix and suffix.</param>
    /// <param name="word">The word to check against.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="prefixSuffix" /> is both a prefix and a suffix of <paramref name="word" />; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    private static bool IsPrefixAndSuffix(string prefixSuffix, string word)
    {
        return IsPrefix(prefixSuffix, word) && IsSuffix(prefixSuffix, word);
    }

    /// <summary>
    ///     Determines whether <paramref name="word" /> starts with <paramref name="prefix" />.
    /// </summary>
    /// <param name="prefix">The candidate prefix.</param>
    /// <param name="word">The word to check against.</param>
    /// <returns><see langword="true" /> if <paramref name="word" /> starts with <paramref name="prefix" />; otherwise, <see langword="false" />.</returns>
    private static bool IsPrefix(string prefix, string word)
    {
        return word.StartsWith(prefix);
    }

    /// <summary>
    ///     Determines whether <paramref name="word" /> ends with <paramref name="suffix" />.
    /// </summary>
    /// <param name="suffix">The candidate suffix.</param>
    /// <param name="word">The word to check against.</param>
    /// <returns><see langword="true" /> if <paramref name="word" /> ends with <paramref name="suffix" />; otherwise, <see langword="false" />.</returns>
    private static bool IsSuffix(string suffix, string word)
    {
        return word.EndsWith(suffix);
    }

    private class Node
    {
        public Dictionary<char, Node> Nodes { get; } = new();
    }
}