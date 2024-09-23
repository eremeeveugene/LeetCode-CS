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

namespace LeetCode.Core.Models;

public class Trie
{
    public Trie(IEnumerable<string> words)
    {
        AddRange(words);
    }

    public TrieNode Root { get; } = new();

    public void Add(string word)
    {
        var node = Root;

        foreach (var c in word)
        {
            if (!node.Children.TryGetValue(c, out var value))
            {
                value = new TrieNode();

                node.Children[c] = value;
            }

            node = value;
        }

        node.Word = word;
    }

    public void AddRange(IEnumerable<string> words)
    {
        foreach (var word in words)
        {
            Add(word);
        }
    }
}