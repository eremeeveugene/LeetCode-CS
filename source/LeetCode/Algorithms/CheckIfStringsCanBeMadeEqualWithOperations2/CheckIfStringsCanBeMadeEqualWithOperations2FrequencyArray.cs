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

namespace LeetCode.Algorithms.CheckIfStringsCanBeMadeEqualWithOperations2;

/// <inheritdoc />
public sealed class CheckIfStringsCanBeMadeEqualWithOperations2FrequencyArray :
    ICheckIfStringsCanBeMadeEqualWithOperations2
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public bool CheckStrings(string s1, string s2)
    {
        Span<int> evenFrequencies = stackalloc int[AlphabetLength];
        Span<int> oddFrequencies = stackalloc int[AlphabetLength];

        for (var i = 0; i < s1.Length; i++)
        {
            var index1 = GetIndex(s1[i]);
            var index2 = GetIndex(s2[i]);

            if (i % 2 == 0)
            {
                evenFrequencies[index1]++;
                evenFrequencies[index2]--;
            }
            else
            {
                oddFrequencies[index1]++;
                oddFrequencies[index2]--;
            }
        }

        for (var i = 0; i < AlphabetLength; i++)
        {
            if (oddFrequencies[i] == 0 && evenFrequencies[i] == 0)
            {
                continue;
            }

            return false;
        }

        return true;
    }

    private static int GetIndex(char c)
    {
        return c - 'a';
    }
}