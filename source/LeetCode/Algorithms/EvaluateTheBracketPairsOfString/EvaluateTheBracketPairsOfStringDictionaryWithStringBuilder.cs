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

namespace LeetCode.Algorithms.EvaluateTheBracketPairsOfString;

/// <inheritdoc />
public sealed class EvaluateTheBracketPairsOfStringDictionaryWithStringBuilder : IEvaluateTheBracketPairsOfString
{
    private const char OpeningBracket = '(';
    private const char ClosingBracket = ')';
    private const string UnknownKeyValue = "?";

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + k), where n is the string length and k is the number of knowledge entries
    ///     Space complexity - O(n + k)
    /// </remarks>
    public string Evaluate(string s, IList<IList<string>> knowledge)
    {
        var k = knowledge.Count;

        var keyToValueDictionary = new Dictionary<string, string>(k);

        for (var i = 0; i < k; i++)
        {
            var knowledgeEntry = knowledge[i];

            var key = knowledgeEntry[0];
            var value = knowledgeEntry[1];

            keyToValueDictionary.Add(key, value);
        }

        var keyToValueLookup = keyToValueDictionary.GetAlternateLookup<ReadOnlySpan<char>>();

        var n = s.Length;

        var resultStringBuilder = new StringBuilder(n);

        for (var i = 0; i < n; i++)
        {
            if (s[i] == OpeningBracket)
            {
                var keyStartIndex = i + 1;

                do
                {
                    i++;
                } while (s[i] != ClosingBracket);

                var keyLength = i - keyStartIndex;

                var key = s.AsSpan(keyStartIndex, keyLength);

                var word = keyToValueLookup.TryGetValue(key, out var value) ? value : UnknownKeyValue;

                resultStringBuilder.Append(word);
            }
            else
            {
                resultStringBuilder.Append(s[i]);
            }
        }

        return resultStringBuilder.ToString();
    }
}