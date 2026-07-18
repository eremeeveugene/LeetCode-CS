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

namespace LeetCode.Algorithms.SortVowelsInString;

/// <inheritdoc />
public sealed class SortVowelsInStringCountingSort : ISortVowelsInString
{
    private const string VowelOrder = "AEIOUaeiou";

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public string SortVowels(string s)
    {
        var n = s.Length;

        Span<int> vowelFrequencies = stackalloc int[VowelOrder.Length];
        Span<char> sCharArray = stackalloc char[s.Length];

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            sCharArray[i] = c;

            var vowelIndex = GetVowelIndex(c);

            if (vowelIndex < 0)
            {
                continue;
            }

            vowelFrequencies[vowelIndex]++;
        }

        var nextVowelIndex = 0;

        for (var i = 0; i < n; i++)
        {
            var vowelIndex = GetVowelIndex(sCharArray[i]);

            if (vowelIndex < 0)
            {
                continue;
            }

            while (vowelFrequencies[nextVowelIndex] == 0)
            {
                nextVowelIndex++;
            }

            sCharArray[i] = VowelOrder[nextVowelIndex];

            vowelFrequencies[nextVowelIndex]--;
        }

        return new string(sCharArray);
    }

    private static int GetVowelIndex(char c)
    {
        return c switch
        {
            'A' => 0,
            'E' => 1,
            'I' => 2,
            'O' => 3,
            'U' => 4,
            'a' => 5,
            'e' => 6,
            'i' => 7,
            'o' => 8,
            'u' => 9,
            _ => -1
        };
    }
}