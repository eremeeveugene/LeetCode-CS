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

namespace LeetCode.Algorithms.FindTheLongestSubstringContainingVowelsInEvenCounts;

/// <inheritdoc />
public sealed class FindTheLongestSubstringContainingVowelsInEvenCountsBitmasking : IFindTheLongestSubstringContainingVowelsInEvenCounts
{
    private const char FirstLetter = 'a';
    private const int XorStateCount = 32;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindTheLongestSubstring(string s)
    {
        var vowelXorValues = new int['z' - FirstLetter + 1];

        vowelXorValues['a' - FirstLetter] = 1;
        vowelXorValues['e' - FirstLetter] = 2;
        vowelXorValues['i' - FirstLetter] = 4;
        vowelXorValues['o' - FirstLetter] = 8;
        vowelXorValues['u' - FirstLetter] = 16;

        var xorStateFirstIndex = new int[XorStateCount];

        for (var i = 0; i < XorStateCount; i++)
        {
            xorStateFirstIndex[i] = -1;
        }

        var longestSubstringLength = 0;
        var currentXorState = 0;

        for (var i = 0; i < s.Length; i++)
        {
            currentXorState ^= vowelXorValues[s[i] - FirstLetter];

            if (xorStateFirstIndex[currentXorState] == -1 && currentXorState != 0)
            {
                xorStateFirstIndex[currentXorState] = i;
            }

            longestSubstringLength = Math.Max(longestSubstringLength, i - xorStateFirstIndex[currentXorState]);
        }

        return longestSubstringLength;
    }
}