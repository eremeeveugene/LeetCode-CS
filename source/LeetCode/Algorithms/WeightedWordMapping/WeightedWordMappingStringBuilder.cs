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

namespace LeetCode.Algorithms.WeightedWordMapping;

/// <inheritdoc />
public sealed class WeightedWordMappingStringBuilder : IWeightedWordMapping
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m) where n is the number of words and m is the maximum word length
    ///     Space complexity - O(1)
    /// </remarks>
    public string MapWordWeights(string[] words, int[] weights)
    {
        var n = words.Length;

        var mappedCharactersStringBuilder = new StringBuilder(n);

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

            var mappedCharacter = (char)('z' - (weightsSum % AlphabetLength));

            mappedCharactersStringBuilder.Append(mappedCharacter);
        }

        return mappedCharactersStringBuilder.ToString();
    }
}