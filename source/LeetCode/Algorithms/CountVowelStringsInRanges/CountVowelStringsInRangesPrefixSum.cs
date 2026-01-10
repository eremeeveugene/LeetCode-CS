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

namespace LeetCode.Algorithms.CountVowelStringsInRanges;

/// <inheritdoc />
public sealed class CountVowelStringsInRangesPrefixSum : ICountVowelStringsInRanges
{
    private readonly HashSet<char> _vowelsHashSet =
    [
        'a',
        'e',
        'i',
        'o',
        'u'
    ];

    public int[] VowelStrings(string[] words, int[][] queries)
    {
        var prefixSum = new int[words.Length + 1];

        for (var i = 0; i < words.Length; i++)
        {
            if (_vowelsHashSet.Contains(words[i][0]) && _vowelsHashSet.Contains(words[i][^1]))
            {
                prefixSum[i + 1] = prefixSum[i] + 1;
            }
            else
            {
                prefixSum[i + 1] = prefixSum[i];
            }
        }

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            result[i] = prefixSum[queries[i][1] + 1] - prefixSum[queries[i][0]];
        }

        return result;
    }
}