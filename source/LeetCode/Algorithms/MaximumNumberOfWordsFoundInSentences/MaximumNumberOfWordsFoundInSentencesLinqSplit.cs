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
public sealed class MaximumNumberOfWordsFoundInSentencesLinqSplit : IMaximumNumberOfWordsFoundInSentences
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </remarks>
    public int MostWordsFound(string[] sentences)
    {
        return sentences.Select(sentence => sentence.Split(' ')).Select(words => words.Length).Max();
    }
}