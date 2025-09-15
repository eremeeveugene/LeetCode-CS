// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MaximumNumberOfWordsYouCanTypeLookup : IMaximumNumberOfWordsYouCanType
{
    private const int AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n + m), where n is the length of the text and m is the length of brokenLetters
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="brokenLetters"></param>
    /// <returns></returns>
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        Span<bool> brokenLettersLookup = stackalloc bool[AlphabetLength];

        for (var i = 0; i < brokenLetters.Length; i++)
        {
            var brokenLetterIndex = brokenLetters[i] - 'a';

            brokenLettersLookup[brokenLetterIndex] = true;
        }

        var count = 0;

        var isBroken = false;

        for (var i = 0; i < text.Length; i++)
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
                    count++;
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
            count++;
        }

        return count;
    }
}