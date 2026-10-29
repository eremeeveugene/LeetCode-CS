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

namespace LeetCode.Core.Models;

/// <summary>
///     A prefix tree that stores words and answers word and prefix queries in time proportional to the query length.
/// </summary>
public sealed class Trie
{
    private readonly Node _root = new();

    /// <summary>
    ///     Initializes a new instance of the <see cref="Trie" /> class that contains no words.
    /// </summary>
    public Trie()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Trie" /> class that contains <paramref name="words" />.
    /// </summary>
    /// <param name="words">The words to insert into the trie.</param>
    /// <remarks>
    ///     Time complexity - O(n * L), where n is the number of words and L is the length of the longest word
    ///     Space complexity - O(n * L), where n is the number of words and L is the length of the longest word
    /// </remarks>
    public Trie(IList<string> words)
    {
        var n = words.Count;

        for (var i = 0; i < n; i++)
        {
            var word = words[i];

            Insert(word);
        }
    }

    /// <summary>
    ///     Inserts <paramref name="word" /> into the trie.
    /// </summary>
    /// <param name="word">The word to insert.</param>
    /// <remarks>
    ///     Time complexity - O(L), where L is the length of the word
    ///     Space complexity - O(L), where L is the length of the word
    /// </remarks>
    public void Insert(string word)
    {
        var currentNode = _root;

        var n = word.Length;

        for (var i = 0; i < n; i++)
        {
            var c = word[i];

            if (!currentNode.Children.TryGetValue(c, out var childNode))
            {
                childNode = new Node();

                currentNode.Children[c] = childNode;
            }

            currentNode = childNode;
        }

        currentNode.IsWord = true;
    }

    /// <summary>
    ///     Determines whether <paramref name="word" /> has been inserted into the trie.
    /// </summary>
    /// <param name="word">The word to search for.</param>
    /// <returns><see langword="true" /> if <paramref name="word" /> is in the trie; otherwise, <see langword="false" />.</returns>
    /// <remarks>
    ///     Time complexity - O(L), where L is the length of the word
    ///     Space complexity - O(1)
    /// </remarks>
    public bool Search(string word)
    {
        var node = Traverse(word);

        return node is { IsWord: true };
    }

    /// <summary>
    ///     Determines whether any inserted word starts with <paramref name="prefix" />.
    /// </summary>
    /// <param name="prefix">The prefix to search for.</param>
    /// <returns>
    ///     <see langword="true" /> if an inserted word starts with <paramref name="prefix" />; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(L), where L is the length of the prefix
    ///     Space complexity - O(1)
    /// </remarks>
    public bool StartsWith(string prefix)
    {
        var node = Traverse(prefix);

        return node != null;
    }

    /// <summary>
    ///     Finds the shortest inserted word that is a prefix of <paramref name="text" />.
    /// </summary>
    /// <param name="text">The text whose prefixes are searched.</param>
    /// <param name="length">
    ///     When this method returns <see langword="true" />, the length of the shortest inserted word that is a prefix of
    ///     <paramref name="text" />; otherwise, <c>0</c>.
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if an inserted word is a prefix of <paramref name="text" />; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(L), where L is the length of the text
    ///     Space complexity - O(1)
    /// </remarks>
    public bool TryFindShortestPrefix(ReadOnlySpan<char> text, out int length)
    {
        var currentNode = _root;

        var n = text.Length;

        for (var i = 0; i < n; i++)
        {
            if (currentNode.IsWord)
            {
                length = i;

                return true;
            }

            var c = text[i];

            if (!currentNode.Children.TryGetValue(c, out var childNode))
            {
                break;
            }

            currentNode = childNode;
        }

        if (currentNode.IsWord)
        {
            length = n;

            return true;
        }

        length = 0;

        return false;
    }

    /// <summary>
    ///     Finds the lengths of all inserted words that are prefixes of <paramref name="text" />.
    /// </summary>
    /// <param name="text">The text whose prefixes are searched.</param>
    /// <returns>The lengths of the inserted words that are prefixes of <paramref name="text" />, in ascending order.</returns>
    /// <remarks>
    ///     Time complexity - O(L), where L is the length of the text
    ///     Space complexity - O(L), where L is the length of the text
    /// </remarks>
    public List<int> FindPrefixLengths(ReadOnlySpan<char> text)
    {
        var prefixLengths = new List<int>();

        var currentNode = _root;

        var n = text.Length;

        for (var i = 0; i < n; i++)
        {
            if (currentNode.IsWord)
            {
                prefixLengths.Add(i);
            }

            var c = text[i];

            if (!currentNode.Children.TryGetValue(c, out var childNode))
            {
                return prefixLengths;
            }

            currentNode = childNode;
        }

        if (currentNode.IsWord)
        {
            prefixLengths.Add(n);
        }

        return prefixLengths;
    }

    /// <summary>
    ///     Follows the path spelled by <paramref name="text" /> from the root.
    /// </summary>
    /// <param name="text">The characters to follow.</param>
    /// <returns>
    ///     The node at the end of the path, or <see langword="null" /> if the trie does not contain the path.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(L), where L is the length of the text
    ///     Space complexity - O(1)
    /// </remarks>
    private Node? Traverse(ReadOnlySpan<char> text)
    {
        var currentNode = _root;

        var n = text.Length;

        for (var i = 0; i < n; i++)
        {
            var c = text[i];

            if (!currentNode.Children.TryGetValue(c, out var childNode))
            {
                return null;
            }

            currentNode = childNode;
        }

        return currentNode;
    }

    /// <summary>
    ///     A node of the trie.
    /// </summary>
    private sealed class Node
    {
        /// <summary>
        ///     Gets the child nodes, keyed by the character on the edge leading to each child.
        /// </summary>
        public Dictionary<char, Node> Children { get; } = [];

        /// <summary>
        ///     Gets or sets a value indicating whether an inserted word ends at this node.
        /// </summary>
        public bool IsWord { get; set; }
    }
}