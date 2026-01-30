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

namespace LeetCode.Algorithms.FindResultantArrayAfterRemovingAnagrams;

/// <inheritdoc />
public sealed class FindResultantArrayAfterRemovingAnagramsGreedyCounting : IFindResultantArrayAfterRemovingAnagrams
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n * L), where n is the number of words and L is the average length of a word
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public IList<string> RemoveAnagrams(string[] words)
    {
        var result = new List<string>(words.Length)
        {
            words[0]
        };

        for (var i = 1; i < words.Length; i++)
        {
            if (AreAnagrams(words[i], result[^1]))
            {
                continue;
            }

            result.Add(words[i]);
        }

        return result;
    }

    private static bool AreAnagrams(string a, string b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }

        Span<int> frequencies = stackalloc int[AlphabetLength];

        for (var i = 0; i < a.Length; i++)
        {
            var aIndex = GetIndex(a[i]);

            frequencies[aIndex]++;

            var bIndex = GetIndex(b[i]);

            frequencies[bIndex]--;
        }

        for (var i = 0; i < AlphabetLength; i++)
        {
            if (frequencies[i] == 0)
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