// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MaximumNumberOfWordsFoundInSentencesLinqSplit : IMaximumNumberOfWordsFoundInSentences
{
    /// <summary>
    ///     Time complexity - O(n + m)
    /// </summary>
    /// <param name="sentences"></param>
    /// <returns></returns>
    public int MostWordsFound(string[] sentences)
    {
        return sentences.Select(sentence => sentence.Split(' ')).Select(words => words.Length).Max();
    }
}