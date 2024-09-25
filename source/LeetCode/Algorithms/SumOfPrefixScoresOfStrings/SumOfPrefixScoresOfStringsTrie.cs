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

namespace LeetCode.Algorithms.SumOfPrefixScoresOfStrings;

/// <inheritdoc />
public class SumOfPrefixScoresOfStringsTrie : ISumOfPrefixScoresOfStrings
{
    /// <summary>
    ///     Time complexity - O(N * L), where N is the number of words and L is the average length of the words
    ///     Space complexity - O(N * L), where N is the number of words and L is the average length of the words
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public int[] SumPrefixScores(string[] words)
    {
        var trie = new Trie(words);

        var result = new int[words.Length];

        for (var i = 0; i < words.Length; i++)
        {
            var sum = 0;

            var currentTrieNode = trie.Root;

            foreach (var character in words[i])
            {
                var characterTrieNodeIndex = character - 'a';

                var characterTrieNode = currentTrieNode.Children[characterTrieNodeIndex];

                if (characterTrieNode == null)
                {
                    break;
                }

                sum += characterTrieNode.Count;

                currentTrieNode = characterTrieNode;
            }

            result[i] = sum;
        }

        return result;
    }

    private class Trie
    {
        public Trie(IEnumerable<string> words)
        {
            AddRange(words);
        }

        public TrieNode Root { get; } = new();

        private void AddRange(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                Add(word);
            }
        }

        private void Add(string word)
        {
            var currentTrieNode = Root;

            foreach (var character in word)
            {
                var characterTrieNodeIndex = character - 'a';

                var characterTrieNode = currentTrieNode.Children[characterTrieNodeIndex];

                if (characterTrieNode != null)
                {
                    currentTrieNode = characterTrieNode;
                }
                else
                {
                    var newTrieNode = new TrieNode();

                    currentTrieNode.Children[characterTrieNodeIndex] = newTrieNode;

                    currentTrieNode = newTrieNode;
                }

                currentTrieNode.Count++;
            }
        }
    }

    private class TrieNode
    {
        public readonly TrieNode?[] Children = new TrieNode['z' - 'a' + 1];

        public int Count { get; set; }
    }
}