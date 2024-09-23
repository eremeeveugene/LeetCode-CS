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

namespace LeetCode.Algorithms.ExtraCharactersInString;

/// <inheritdoc />
public class ExtraCharactersInStringDynamicProgrammingHashSet : IExtraCharactersInString
{
    /// <summary>
    ///     Time complexity - O(n^3), n is the length of the longest word in the dictionary
    ///     Space complexity - O(n + m), m is the number of words in the dictionary and n is the length of the longest word in
    ///     the dictionary
    /// </summary>
    /// <param name="s"></param>
    /// <param name="dictionary"></param>
    /// <returns></returns>
    public int MinExtraChar(string s, string[] dictionary)
    {
        var dp = new int[s.Length + 1];

        Array.Fill(dp, int.MaxValue);

        dp[0] = 0;

        var wordsHashSet = new HashSet<string>(dictionary);

        for (var i = 1; i < dp.Length; i++)
        {
            dp[i] = dp[i - 1] + 1;

            for (var j = 0; j < i; j++)
            {
                var word = s.Substring(j, i - j);

                if (wordsHashSet.Contains(word))
                {
                    dp[i] = Math.Min(dp[i], dp[j]);
                }
            }
        }

        return dp[^1];
    }
}