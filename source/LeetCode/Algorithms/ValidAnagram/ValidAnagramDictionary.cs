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

namespace LeetCode.Algorithms.ValidAnagram;

/// <inheritdoc />
public class ValidAnagramDictionary : IValidAnagram
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dictionary = new Dictionary<char, int>();

        foreach (var c in s.Where(c => !dictionary.TryAdd(c, 1)))
        {
            dictionary[c]++;
        }

        foreach (var c in t)
        {
            if (!dictionary.TryGetValue(c, out var value))
            {
                return false;
            }

            dictionary[c] = --value;

            if (value < 0)
            {
                return false;
            }
        }

        return true;
    }
}