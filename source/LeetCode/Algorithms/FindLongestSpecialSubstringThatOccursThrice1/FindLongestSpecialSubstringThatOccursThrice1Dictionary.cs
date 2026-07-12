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
        var dictionary = new Dictionary<string, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var substring = new StringBuilder();

            for (var j = i; j < s.Length && s[j] == s[i]; j++)
            {
                substring.Append(s[j]);

                var key = substring.ToString();

                if (!dictionary.TryAdd(key, 1))
                {
                    dictionary[key]++;
                }
            }
        }

        return dictionary.Where(keyValuePair => keyValuePair.Value >= 3).Select(keyValuePair => keyValuePair.Key.Length).DefaultIfEmpty(-1).Max();
    }
}