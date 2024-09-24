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

namespace LeetCode.Algorithms.FindTheLengthOfTheLongestCommonPrefix;

/// <inheritdoc />
public class FindTheLengthOfTheLongestCommonPrefixTrie : IFindTheLengthOfTheLongestCommonPrefix
{
    /// <summary>
    ///     Time complexity - O((n + m) * d), where n is the number of elements in arr1, m is the number of elements in
    ///     arr2, d is the average number of digits in the numbers
    ///     Space complexity - O(n * d), where n is the number of elements in arr1, d is the average number of digits in arr1
    /// </summary>
    /// <param name="arr1"></param>
    /// <param name="arr2"></param>
    /// <returns></returns>
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        var trie = new Trie(arr1);

        return arr2.Select(trie.FindLongestPrefix).Prepend(0).Max();
    }

    private class TrieNode
    {
        public TrieNode?[] Children { get; } = new TrieNode[10];
    }

    private class Trie
    {
        private readonly TrieNode _root = new();

        public Trie(IEnumerable<int> nums)
        {
            AddRange(nums);
        }

        private void AddRange(IEnumerable<int> nums)
        {
            foreach (var num in nums)
            {
                Add(num);
            }
        }

        private void Add(int num)
        {
            var node = _root;
            var numStr = num.ToString();

            foreach (var idx in numStr.Select(digit => digit - '0'))
            {
                if (node?.Children[idx] == null)
                {
                    if (node != null)
                    {
                        node.Children[idx] = new TrieNode();
                    }
                }

                node = node?.Children[idx];
            }
        }

        public int FindLongestPrefix(int num)
        {
            var node = _root;
            var numStr = num.ToString();
            var longestPrefix = 0;

            foreach (var idx in numStr.Select(digit => digit - '0'))
            {
                if (node?.Children[idx] != null)
                {
                    longestPrefix++;

                    node = node.Children[idx];
                }
                else
                {
                    break;
                }
            }

            return longestPrefix;
        }
    }
}