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

namespace LeetCode.Algorithms.WordPattern;

/// <inheritdoc />
public class WordPatternTwoDictionaries : IWordPattern
{
    /// <summary>
    ///     Time complexity - O(n + m), where n is the length of s and m is the length of pattern
    ///     Space complexity - O(m + k), where m is the number of unique characters in pattern and k is the number of unique
    ///     words in s
    /// </summary>
    /// <param name="pattern"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool WordPattern(string pattern, string s)
    {
        var patternHashSet = new Dictionary<char, string>();
        var sHashSet = new Dictionary<string, char>();

        var sArray = s.Split(' ');

        if (pattern.Length != sArray.Length)
        {
            return false;
        }

        for (var i = 0; i < pattern.Length; i++)
        {
            if (patternHashSet.TryGetValue(pattern[i], out var patternValue))
            {
                if (patternValue != sArray[i])
                {
                    return false;
                }
            }
            else
            {
                if (sHashSet.TryGetValue(sArray[i], out var sValue))
                {
                    if (sValue != pattern[i])
                    {
                        return false;
                    }
                }

                sHashSet.Add(sArray[i], pattern[i]);
                patternHashSet.Add(pattern[i], sArray[i]);
            }
        }

        return true;
    }
}