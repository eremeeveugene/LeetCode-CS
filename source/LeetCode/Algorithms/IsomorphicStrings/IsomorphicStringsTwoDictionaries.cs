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

namespace LeetCode.Algorithms.IsomorphicStrings;

/// <inheritdoc />
public class IsomorphicStringsTwoDictionaries : IIsomorphicStrings
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsIsomorphic(string s, string t)
    {
        var sDictionary = new Dictionary<char, char>();
        var tDictionary = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            var sChar = s[i];
            var tChar = t[i];

            if (!sDictionary.TryAdd(sChar, tChar))
            {
                if (sDictionary[sChar] != tChar)
                {
                    return false;
                }
            }

            if (tDictionary.TryAdd(tChar, sChar))
            {
                continue;
            }

            if (tDictionary[tChar] != sChar)
            {
                return false;
            }
        }

        return true;
    }
}