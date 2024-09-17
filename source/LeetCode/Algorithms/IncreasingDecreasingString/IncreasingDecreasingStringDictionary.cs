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

using System.Text;

namespace LeetCode.Algorithms.IncreasingDecreasingString;

/// <inheritdoc />
public class IncreasingDecreasingStringDictionary : IIncreasingDecreasingString
{
    /// <summary>
    ///     Time complexity - O(n * k * log k), where n is the length of the string and k is the number of unique characters
    ///     Space complexity - O(n + k), where n is the length of the string and k is the number of unique characters
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string SortString(string s)
    {
        var dictionary = new Dictionary<char, int>();

        foreach (var c in s.Where(c => !dictionary.TryAdd(c, 1)))
        {
            dictionary[c]++;
        }

        var stringBuilder = new StringBuilder();

        while (stringBuilder.Length < s.Length)
        {
            foreach (var key in dictionary.Keys.Where(key => dictionary[key] > 0).OrderBy(c => c))
            {
                stringBuilder.Append(key);

                dictionary[key]--;
            }

            foreach (var key in dictionary.Keys.Where(key => dictionary[key] > 0).OrderByDescending(c => c))
            {
                stringBuilder.Append(key);

                dictionary[key]--;
            }
        }

        return stringBuilder.ToString();
    }
}