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

namespace LeetCode.Algorithms.FirstUniqueCharacterInString;

/// <inheritdoc />
public class FirstUniqueCharacterInStringIterative : IFirstUniqueCharacterInString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int FirstUniqChar(string s)
    {
        var charCount = new int[26];

        foreach (var c in s)
        {
            charCount[c - 'a']++;
        }

        for (var i = 0; i < s.Length; i++)
        {
            if (charCount[s[i] - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}