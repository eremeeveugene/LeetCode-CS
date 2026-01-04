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

using System.Text;

namespace LeetCode.Algorithms.UniqueLength3PalindromicSubsequences;

/// <inheritdoc />
public class UniqueLength3PalindromicSubsequencesCounting : IUniqueLength3PalindromicSubsequences
{
    private const int AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n * 26)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int CountPalindromicSubsequence(string s)
    {
        var firstOccurrence = new int[AlphabetLength];
        var lastOccurrence = new int[AlphabetLength];

        Array.Fill(firstOccurrence, -1);
        Array.Fill(lastOccurrence, -1);

        for (var i = 0; i < s.Length; i++)
        {
            var index = s[i] - 'a';

            if (firstOccurrence[index] == -1)
            {
                firstOccurrence[index] = i;
            }

            lastOccurrence[index] = i;
        }

        var palindromesHashSet = new HashSet<string>();

        for (var i = 0; i < AlphabetLength; i++)
        {
            if (firstOccurrence[i] == -1 || firstOccurrence[i] >= lastOccurrence[i])
            {
                continue;
            }

            var start = firstOccurrence[i];
            var end = lastOccurrence[i];

            var middleCharsHashSet = new HashSet<char>();

            for (var j = start + 1; j < end; j++)
            {
                middleCharsHashSet.Add(s[j]);
            }

            foreach (var middleChar in middleCharsHashSet)
            {
                var palindromeStringBuilder = new StringBuilder();

                palindromeStringBuilder.Append(i + 'a');
                palindromeStringBuilder.Append(middleChar);
                palindromeStringBuilder.Append(i + 'a');

                var palindrome = palindromeStringBuilder.ToString();

                palindromesHashSet.Add(palindrome);
            }
        }

        return palindromesHashSet.Count;
    }
}