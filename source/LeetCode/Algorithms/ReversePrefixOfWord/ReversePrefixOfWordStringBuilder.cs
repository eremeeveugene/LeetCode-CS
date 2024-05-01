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

using System.Text;

namespace LeetCode.Algorithms.ReversePrefixOfWord;

/// <inheritdoc />
public class ReversePrefixOfWordStringBuilder : IReversePrefixOfWord
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
        var chIndex = word.IndexOf(ch);

        if (chIndex < 0)
        {
            return word;
        }

        var result = new StringBuilder();

        for (var i = chIndex; i >= 0; i--)
        {
            result.Append(word[i]);
        }

        for (var i = chIndex + 1; i < word.Length; i++)
        {
            result.Append(word[i]);
        }

        return result.ToString();
    }
}