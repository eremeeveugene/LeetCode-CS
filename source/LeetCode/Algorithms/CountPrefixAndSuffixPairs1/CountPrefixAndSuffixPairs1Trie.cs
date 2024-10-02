// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class CountPrefixAndSuffixPairs1Trie : ICountPrefixAndSuffixPairs1
{
    private readonly Node _prefixRoot = new();
    private readonly Node _suffixRoot = new();

    /// <summary>
    ///     Time complexity - O(n^2 * L), where L is the average word length
    ///     Space complexity - O(n * L), where L is the average word length
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
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

    private bool IsPrefixAndSuffix(string prefixSuffix, string word)
    {
        return IsPrefix(prefixSuffix, word) && IsSuffix(prefixSuffix, word);
    }

    private bool IsPrefix(string prefix, string word)
    {
        var currentNode = _prefixRoot;

        return word.All(c => currentNode.Nodes.TryGetValue(c, out currentNode)) && word.StartsWith(prefix);
    }

    private bool IsSuffix(string suffix, string word)
    {
        var currentNode = _suffixRoot;
        for (var i = word.Length - 1; i >= 0; i--)
        {
            if (!currentNode.Nodes.TryGetValue(word[i], out currentNode))
            {
                return false;
            }
        }

        return word.EndsWith(suffix);
    }

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

    private class Node
    {
        public Dictionary<char, Node> Nodes { get; } = new();
    }
}