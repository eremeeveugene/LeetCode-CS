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

namespace LeetCode.Algorithms.DesignAddAndSearchWordsDataStructure;

/// <inheritdoc />
/// <remarks>
///     Space complexity - O(t), where t is the total length of added words
/// </remarks>
public sealed class DesignAddAndSearchWordsDataStructureTrie : IDesignAddAndSearchWordsDataStructure
{
    private const char FirstLetter = 'a';
    private const char LastLetter = 'z';
    private const int AlphabetSize = LastLetter - FirstLetter + 1;
    private const char Wildcard = '.';
    private readonly Node _root = new();

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m), where m is the word length
    ///     Space complexity - O(m)
    /// </remarks>
    public void AddWord(string word)
    {
        var n = word.Length;

        var node = _root;

        for (var i = 0; i < n; i++)
        {
            var character = word[i];
            var characterIndex = GetCharacterIndex(character);

            node = node.Nodes[characterIndex] ??= new Node();
        }

        node.IsWord = true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * 26^d), where m is the pattern length and d is the number of dots
    ///     Space complexity - O(m)
    /// </remarks>
    public bool Search(string word)
    {
        return MatchesWord(_root, word, 0);
    }

    /// <summary>
    ///     Matches the remaining pattern from the current node, exploring child branches for a wildcard.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(m * 26^d), where m is the remaining pattern length and d is the remaining number of dots
    ///     Space complexity - O(m)
    /// </remarks>
    private static bool MatchesWord(Node node, string word, int index)
    {
        var n = word.Length;

        if (index == n)
        {
            return node.IsWord;
        }

        var character = word[index];
        var nextCharacterIndex = index + 1;
        var childNodes = node.Nodes;

        if (character == Wildcard)
        {
            return MatchesAnyChild(childNodes, word, nextCharacterIndex);
        }

        var childCharacterIndex = GetCharacterIndex(character);
        var childNode = childNodes[childCharacterIndex];

        return childNode is not null && MatchesWord(childNode, word, nextCharacterIndex);
    }

    /// <summary>
    ///     Matches the remaining pattern against any child after consuming a wildcard.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(m * 26^d), where m is the pattern length and d is the number of dots
    ///     Space complexity - O(m)
    /// </remarks>
    private static bool MatchesAnyChild(Node?[] childNodes, string word, int nextCharacterIndex)
    {
        for (var i = 0; i < AlphabetSize; i++)
        {
            var childNode = childNodes[i];

            if (childNode is not null && MatchesWord(childNode, word, nextCharacterIndex))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    ///     Converts a lowercase letter to its zero-based alphabet index.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetCharacterIndex(char character)
    {
        return character - FirstLetter;
    }

    private sealed class Node
    {
        public Node?[] Nodes { get; } = new Node?[AlphabetSize];

        public bool IsWord { get; set; }
    }
}