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
public class CountPrefixAndSuffixPairs1StringComparison : ICountPrefixAndSuffixPairs1
{
    /// <summary>
    ///     Time complexity - O(n^2 * m), where m is the maximum word length
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public int CountPrefixSuffixPairs(string[] words)
    {
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

    private static bool IsPrefixAndSuffix(string prefixSuffix, string word)
    {
        return word.StartsWith(prefixSuffix) && word.EndsWith(prefixSuffix);
    }
}