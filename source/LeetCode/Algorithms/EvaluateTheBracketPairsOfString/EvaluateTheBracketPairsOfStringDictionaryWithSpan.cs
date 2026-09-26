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

namespace LeetCode.Algorithms.EvaluateTheBracketPairsOfString;

/// <inheritdoc />
public sealed class EvaluateTheBracketPairsOfStringDictionaryWithSpan : IEvaluateTheBracketPairsOfString
{
    private const int MinimumBracketPairLength = 3;
    private const char OpeningBracket = '(';
    private const char ClosingBracket = ')';
    private const string UnknownKeyValue = "?";

    /// <inheritdoc />
    /// <remarks>
    ///     Uses a stack-allocated output buffer for small results and a heap-backed span for larger results.
    ///     Each bracket pair consumes at least three input characters, bounding the maximum output growth.
    ///     Time complexity - O(n + k), where n is the string length and k is the number of knowledge entries
    ///     Space complexity - O(n + k)
    /// </remarks>
    public string Evaluate(string s, IList<IList<string>> knowledge)
    {
        var k = knowledge.Count;
        var maximumValueLength = UnknownKeyValue.Length;

        var keyToValueDictionary = new Dictionary<string, string>(k);

        for (var i = 0; i < k; i++)
        {
            var knowledgeEntry = knowledge[i];

            var key = knowledgeEntry[0];
            var value = knowledgeEntry[1];

            keyToValueDictionary.Add(key, value);

            maximumValueLength = Math.Max(maximumValueLength, value.Length);
        }

        var keyToValueLookup = keyToValueDictionary.GetAlternateLookup<ReadOnlySpan<char>>();

        var n = s.Length;

        var maximumBracketPairCount = n / MinimumBracketPairLength;
        var maximumGrowthPerReplacement = Math.Max(0, maximumValueLength - MinimumBracketPairLength);
        var bufferLength = n + (maximumBracketPairCount * maximumGrowthPerReplacement);

        Span<char> resultBuffer = stackalloc char[bufferLength];

        var resultLength = 0;

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

                word.AsSpan().CopyTo(resultBuffer[resultLength..]);

                resultLength += word.Length;
            }
            else
            {
                resultBuffer[resultLength] = s[i];

                resultLength++;
            }
        }

        return new string(resultBuffer[..resultLength]);
    }
}