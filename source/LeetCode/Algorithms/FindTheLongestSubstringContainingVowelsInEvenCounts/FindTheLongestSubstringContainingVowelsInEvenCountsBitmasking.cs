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

namespace LeetCode.Algorithms.FindTheLongestSubstringContainingVowelsInEvenCounts;

/// <inheritdoc />
public class FindTheLongestSubstringContainingVowelsInEvenCountsBitmasking :
    IFindTheLongestSubstringContainingVowelsInEvenCounts
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int FindTheLongestSubstring(string s)
    {
        var vowelXorValues = new int['z' - 'a' + 1];

        vowelXorValues['a' - 'a'] = 1;
        vowelXorValues['e' - 'a'] = 2;
        vowelXorValues['i' - 'a'] = 4;
        vowelXorValues['o' - 'a'] = 8;
        vowelXorValues['u' - 'a'] = 16;

        var xorStateFirstIndex = new int[32];

        for (var i = 0; i < 32; i++)
        {
            xorStateFirstIndex[i] = -1;
        }

        var longestSubstringLength = 0;
        var currentXorState = 0;

        for (var i = 0; i < s.Length; i++)
        {
            currentXorState ^= vowelXorValues[s[i] - 'a'];

            if (xorStateFirstIndex[currentXorState] == -1 && currentXorState != 0)
            {
                xorStateFirstIndex[currentXorState] = i;
            }

            longestSubstringLength = Math.Max(longestSubstringLength, i - xorStateFirstIndex[currentXorState]);
        }

        return longestSubstringLength;
    }
}