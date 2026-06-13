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

namespace LeetCode.Algorithms.WeightedWordMapping;

/// <inheritdoc />
public sealed class WeightedWordMappingSpan : IWeightedWordMapping
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m) where n is the number of words and m is the maximum word length
    ///     Space complexity - O(n) for the resulting string
    /// </remarks>
    public string MapWordWeights(string[] words, int[] weights)
    {
        var n = words.Length;

        Span<char> mappedCharacters = stackalloc char[n];

        for (var i = 0; i < n; i++)
        {
            var word = words[i];

            var m = word.Length;

            var weightsSum = 0;

            for (var j = 0; j < m; j++)
            {
                var character = word[j];
                var characterIndex = character - 'a';

                var weight = weights[characterIndex];

                weightsSum += weight;
            }

            mappedCharacters[i] = (char)('z' - (weightsSum % AlphabetLength));
        }

        return new string(mappedCharacters);
    }
}