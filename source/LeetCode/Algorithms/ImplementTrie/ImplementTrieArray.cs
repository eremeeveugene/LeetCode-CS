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

namespace LeetCode.Algorithms.ImplementTrie;

/// <inheritdoc />
public sealed class ImplementTrieArray : IImplementTrie
{
    private readonly Node _root = new();

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m), where m is the length of the word
    ///     Space complexity - O(1)
    /// </remarks>
    public void Insert(string word)
    {
        var currentNode = word.Select(c => c - 'a').Aggregate(_root, (current, index) => current.Nodes[index] ??= new Node());

        currentNode.IsWord = true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m), where m is the length of the word
    ///     Space complexity - O(1)
    /// </remarks>
    public bool Search(string word)
    {
        var currentNode = Traverse(word);

        return currentNode is { IsWord: true };
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m), where m is the length of the prefix
    ///     Space complexity - O(1)
    /// </remarks>
    public bool StartsWith(string prefix)
    {
        return Traverse(prefix) != null;
    }

    private Node? Traverse(string str)
    {
        var currentNode = _root;

        foreach (var index in str.Select(c => c - 'a'))
        {
            currentNode = currentNode.Nodes[index];

            if (currentNode == null)
            {
                return null;
            }
        }

        return currentNode;
    }

    private sealed class Node
    {
        public Node?[] Nodes { get; } = new Node['z' - 'a' + 1];

        public bool IsWord { get; set; }
    }
}