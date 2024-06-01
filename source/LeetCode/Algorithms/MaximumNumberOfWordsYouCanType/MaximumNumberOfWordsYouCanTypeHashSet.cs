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

namespace LeetCode.Algorithms.MaximumNumberOfWordsYouCanType;

/// <inheritdoc />
public class MaximumNumberOfWordsYouCanTypeHashSet : IMaximumNumberOfWordsYouCanType
{
    /// <summary>
    ///     Time complexity - O(n + m), where n is the length of the text and m is the length of brokenLetters
    ///     Space complexity - O(n + m), where n is the length of the text and m is the length of brokenLetters
    /// </summary>
    /// <param name="text"></param>
    /// <param name="brokenLetters"></param>
    /// <returns></returns>
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        var brokenLettersHashSet = new HashSet<char>(brokenLetters);
        var words = text.Split(' ');
        var count = words.Length;

        foreach (var word in words)
        {
            if (word.Any(brokenLettersHashSet.Contains))
            {
                count--;
            }
        }

        return count;
    }
}