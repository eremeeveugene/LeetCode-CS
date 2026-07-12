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

namespace LeetCode.Algorithms.MaximumNumberOfWordsYouCanType;

/// <inheritdoc />
public sealed class MaximumNumberOfWordsYouCanTypeLookup : IMaximumNumberOfWordsYouCanType
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m), where n is the length of the text and m is the length of brokenLetters
    ///     Space complexity - O(1)
    /// </remarks>
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        Span<bool> brokenLettersLookup = stackalloc bool[AlphabetLength];

        var brokenLettersLength = brokenLetters.Length;

        for (var i = 0; i < brokenLettersLength; i++)
        {
            var brokenLetterIndex = brokenLetters[i] - 'a';

            brokenLettersLookup[brokenLetterIndex] = true;
        }

        var goodWordsCount = 0;

        var isBroken = false;

        var textLength = text.Length;

        for (var i = 0; i < textLength; i++)
        {
            var c = text[i];

            if (c == ' ')
            {
                if (isBroken)
                {
                    isBroken = false;
                }
                else
                {
                    goodWordsCount++;
                }
            }
            else
            {
                var brokenLetterIndex = c - 'a';

                if (!brokenLettersLookup[brokenLetterIndex])
                {
                    continue;
                }

                isBroken = true;
            }
        }

        if (!isBroken)
        {
            goodWordsCount++;
        }

        return goodWordsCount;
    }
}