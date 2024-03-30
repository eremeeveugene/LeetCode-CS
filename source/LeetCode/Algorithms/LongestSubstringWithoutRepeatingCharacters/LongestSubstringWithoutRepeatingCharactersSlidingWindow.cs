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

namespace LeetCode.Algorithms.LongestSubstringWithoutRepeatingCharacters;

/// <inheritdoc />
public class LongestSubstringWithoutRepeatingCharactersSlidingWindow : ILongestSubstringWithoutRepeatingCharacters
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LengthOfLongestSubstring(string s)
    {
        var maxLength = 0;

        var left = 0;

        var charDictionary = new Dictionary<char, int>();

        for (var right = 0; right < s.Length; right++)
        {
            if (!charDictionary.TryAdd(s[right], right))
            {
                left = Math.Max(left, charDictionary[s[right]] + 1);
            }

            charDictionary[s[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}