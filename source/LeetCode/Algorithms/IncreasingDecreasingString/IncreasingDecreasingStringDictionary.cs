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

using System.Text;

namespace LeetCode.Algorithms.IncreasingDecreasingString;

/// <inheritdoc />
public sealed class IncreasingDecreasingStringDictionary : IIncreasingDecreasingString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * k * log k), where n is the length of the string and k is the number of unique characters
    ///     Space complexity - O(n + k), where n is the length of the string and k is the number of unique characters
    /// </remarks>
    public string SortString(string s)
    {
        var dictionary = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (!dictionary.TryAdd(c, 1))
            {
                dictionary[c]++;
            }
        }

        var stringBuilder = new StringBuilder();

        while (stringBuilder.Length < s.Length)
        {
            var keys = new char[dictionary.Count];

            dictionary.Keys.CopyTo(keys, 0);

            Array.Sort(keys);

            for (var i = 0; i < keys.Length; i++)
            {
                var key = keys[i];

                if (dictionary[key] <= 0)
                {
                    continue;
                }

                stringBuilder.Append(key);

                dictionary[key]--;
            }

            for (var i = keys.Length - 1; i >= 0; i--)
            {
                var key = keys[i];

                if (dictionary[key] <= 0)
                {
                    continue;
                }

                stringBuilder.Append(key);

                dictionary[key]--;
            }
        }

        return stringBuilder.ToString();
    }
}