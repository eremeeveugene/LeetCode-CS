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

namespace LeetCode.Algorithms.SortingTheSentence;

/// <inheritdoc />
public class SortingTheSentenceIterative : ISortingTheSentence
{
    /// <summary>
    ///     Time complexity - O(n + m * l), where n is the length of the input string, m is the number of words, and l is
    ///     the average length of these words. Since n is essentially m * l (each character in the input string is part
    ///     of a word), the time complexity simplifies to O(n)
    ///     Space complexity - O(m), where m is the number of words
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string SortSentence(string s)
    {
        var wordsWithIndexes = s.Split(' ');

        var words = new string[wordsWithIndexes.Length];

        foreach (var wordsWithIndex in wordsWithIndexes)
        {
            var index = (int)char.GetNumericValue(wordsWithIndex.Last()) - 1;

            words[index] = wordsWithIndex[..^1];
        }

        return string.Join(' ', words);
    }
}