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

using System.Globalization;

namespace LeetCode.Algorithms.FindTheLengthOfTheLongestCommonPrefix;

/// <inheritdoc />
public sealed class FindTheLengthOfTheLongestCommonPrefixTrie : IFindTheLengthOfTheLongestCommonPrefix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((n + m) * d), where n is the number of elements in arr1, m is the number of elements in
    ///     arr2, d is the average number of digits in the numbers
    ///     Space complexity - O(n * d), where n is the number of elements in arr1, d is the average number of digits in arr1
    /// </remarks>
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        var trie = new Trie(arr1);

        var longestPrefix = 0;

        for (var i = 0; i < arr2.Length; i++)
        {
            var num = arr2[i];

            longestPrefix = Math.Max(longestPrefix, trie.FindLongestPrefix(num));
        }

        return longestPrefix;
    }

    private sealed class TrieNode
    {
        public TrieNode?[] Children { get; } = new TrieNode[10];
    }

    private sealed class Trie
    {
        private readonly TrieNode _root = new();

        public Trie(int[] nums)
        {
            AddRange(nums);
        }

        private void AddRange(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];

                Add(num);
            }
        }

        private void Add(int num)
        {
            var node = _root;
            var numStr = num.ToString(CultureInfo.InvariantCulture);

            for (var i = 0; i < numStr.Length; i++)
            {
                var idx = numStr[i] - '0';

                node.Children[idx] ??= new TrieNode();

                node = node.Children[idx]!;
            }
        }

        public int FindLongestPrefix(int num)
        {
            var node = _root;
            var numStr = num.ToString(CultureInfo.InvariantCulture);
            var longestPrefix = 0;

            for (var i = 0; i < numStr.Length; i++)
            {
                var idx = numStr[i] - '0';

                if (node.Children[idx] != null)
                {
                    longestPrefix++;

                    node = node.Children[idx]!;
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