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
public class WordPatternDictionary : IWordPattern
{
    /// <summary>
    ///     Time complexity - O(m^2), where m is the length of pattern
    ///     Space complexity - O(m), where m is the length of pattern
    /// </summary>
    /// <param name="pattern"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool WordPattern(string pattern, string s)
    {
        var patternHashSet = new Dictionary<char, string>();

        var sArray = s.Split(' ');

        if (pattern.Length != sArray.Length)
        {
            return false;
        }

        for (var i = 0; i < pattern.Length; i++)
        {
            if (patternHashSet.TryGetValue(pattern[i], out var value))
            {
                if (value != sArray[i])
                {
                    return false;
                }
            }
            else
            {
                if (patternHashSet.ContainsValue(sArray[i]))
                {
                    return false;
                }

                patternHashSet.Add(pattern[i], sArray[i]);
            }
        }

        return true;
    }
}