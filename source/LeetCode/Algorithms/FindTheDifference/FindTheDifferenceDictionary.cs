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

namespace LeetCode.Algorithms.FindTheDifference;

/// <inheritdoc />
public sealed class FindTheDifferenceDictionary : IFindTheDifference
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public char FindTheDifference(string s, string t)
    {
        var characterToCountDictionary = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (!characterToCountDictionary.TryAdd(c, 1))
            {
                characterToCountDictionary[c]++;
            }
        }

        for (var i = 0; i < t.Length - 1; i++)
        {
            var c = t[i];

            if (characterToCountDictionary.TryGetValue(c, out var count) && count > 0)
            {
                characterToCountDictionary[c]--;
            }
            else
            {
                return c;
            }
        }

        return t[^1];
    }
}