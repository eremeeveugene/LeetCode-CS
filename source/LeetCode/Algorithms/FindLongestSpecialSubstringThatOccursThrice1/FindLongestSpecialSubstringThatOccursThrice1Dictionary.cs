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

namespace LeetCode.Algorithms.FindLongestSpecialSubstringThatOccursThrice1;

/// <inheritdoc />
public sealed class FindLongestSpecialSubstringThatOccursThrice1Dictionary : IFindLongestSpecialSubstringThatOccursThrice1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public int MaximumLength(string s)
    {
        var substringToCountDictionary = new Dictionary<string, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var substring = new StringBuilder();

            for (var j = i; j < s.Length && s[j] == s[i]; j++)
            {
                substring.Append(s[j]);

                var key = substring.ToString();

                if (!substringToCountDictionary.TryAdd(key, 1))
                {
                    substringToCountDictionary[key]++;
                }
            }
        }

        var substrings = new string[substringToCountDictionary.Count];

        substringToCountDictionary.Keys.CopyTo(substrings, 0);

        var result = -1;

        for (var i = 0; i < substrings.Length; i++)
        {
            var substring = substrings[i];

            if (substringToCountDictionary[substring] >= 3)
            {
                result = Math.Max(result, substring.Length);
            }
        }

        return result;
    }
}