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

namespace LeetCode.Algorithms.CheckIfWordOccursAsPrefixOfAnyWordInSentence;

/// <inheritdoc />
public sealed class CheckIfWordOccursAsPrefixOfAnyWordInSentenceIterative : ICheckIfWordOccursAsPrefixOfAnyWordInSentence
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(m)
    /// </remarks>
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        var words = sentence.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].StartsWith(searchWord, StringComparison.OrdinalIgnoreCase))
            {
                return i + 1;
            }
        }

        return -1;
    }
}