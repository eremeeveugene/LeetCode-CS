// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.LongestPalindromeByConcatenatingTwoLetterWords;

/// <inheritdoc />
public class
    LongestPalindromeByConcatenatingTwoLetterWordsFrequencyArray : ILongestPalindromeByConcatenatingTwoLetterWords
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public int LongestPalindrome(string[] words)
    {
        var longestPalindrome = 0;

        var frequencyArray = new int[26, 26];

        foreach (var word in words)
        {
            var a = word[0] - 'a';
            var b = word[1] - 'a';

            if (frequencyArray[b, a] > 0)
            {
                longestPalindrome += 4;

                frequencyArray[b, a]--;
            }
            else
            {
                frequencyArray[a, b]++;
            }
        }

        for (var i = 0; i < frequencyArray.Length; i++)
        {
            if (frequencyArray[i, i] > 0)
            {
                return longestPalindrome + 2;
            }
        }

        return longestPalindrome;
    }
}