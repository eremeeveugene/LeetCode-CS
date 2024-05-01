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

namespace LeetCode.Algorithms.ReversePrefixOfWord;

/// <inheritdoc />
public class ReversePrefixOfWordArray : IReversePrefixOfWord
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="word"></param>
    /// <param name="ch"></param>
    /// <returns></returns>
    public string ReversePrefix(string word, char ch)
    {
        var wordArray = word.ToCharArray();
        var chIndex = word.IndexOf(ch);

        if (chIndex >= 0)
        {
            Array.Reverse(wordArray, 0, chIndex + 1);
        }

        return new string(wordArray);
    }
}