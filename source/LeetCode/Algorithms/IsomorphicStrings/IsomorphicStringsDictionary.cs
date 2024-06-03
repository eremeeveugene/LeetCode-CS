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
public class IsomorphicStringsDictionary : IIsomorphicStrings
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsIsomorphic(string s, string t)
    {
        var dictionary = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            if (dictionary.TryGetValue(s[i], out var value))
            {
                if (value.Equals(t[i]))
                {
                    continue;
                }

                return false;
            }

            if (dictionary.ContainsValue(t[i]))
            {
                return false;
            }

            dictionary.Add(s[i], t[i]);
        }

        return true;
    }
}