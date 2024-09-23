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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.ExtraCharactersInString;

/// <inheritdoc />
public class ExtraCharactersInStringDynamicProgrammingTrie : IExtraCharactersInString
{
    /// <summary>
    ///     Time complexity - O(L^2 × n), where L is the length of s and n is the length of the longest word in the dictionary
    ///     Space complexity - O(m * n + L), where L is the length of s, m is the number of words in the dictionary and n is
    ///     the length of the longest word in the dictionary
    /// </summary>
    /// <param name="s"></param>
    /// <param name="dictionary"></param>
    /// <returns></returns>
    public int MinExtraChar(string s, string[] dictionary)
    {
        var trie = new Trie(dictionary);

        var dp = new int[s.Length + 1];

        for (var start = s.Length - 1; start >= 0; start--)
        {
            dp[start] = dp[start + 1] + 1;

            var node = trie.Root;

            for (var end = start; end < s.Length; end++)
            {
                if (!node.Children.ContainsKey(s[end]))
                {
                    break;
                }

                node = node.Children[s[end]];

                if (node.Word != null)
                {
                    dp[start] = Math.Min(dp[start], dp[end + 1]);
                }
            }
        }

        return dp[0];
    }
}