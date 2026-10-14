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

namespace LeetCode.Algorithms.MaximumNumberOfWordsFoundInSentences;

/// <inheritdoc />
public sealed class MaximumNumberOfWordsFoundInSentencesIterative : IMaximumNumberOfWordsFoundInSentences
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MostWordsFound(string[] sentences)
    {
        var maxWordsCount = 0;

        for (var i = 0; i < sentences.Length; i++)
        {
            var sentence = sentences[i];

            var wordsCount = 1;

            for (var j = 0; j < sentence.Length; j++)
            {
                var character = sentence[j];

                if (character == ' ')
                {
                    wordsCount++;
                }
            }

            maxWordsCount = Math.Max(maxWordsCount, wordsCount);
        }

        return maxWordsCount;
    }
}