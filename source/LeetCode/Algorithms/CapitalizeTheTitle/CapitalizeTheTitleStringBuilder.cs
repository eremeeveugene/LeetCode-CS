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

namespace LeetCode.Algorithms.CapitalizeTheTitle;

/// <inheritdoc />
public class CapitalizeTheTitleStringBuilder : ICapitalizeTheTitle
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="title"></param>
    /// <returns></returns>
    public string CapitalizeTitle(string title)
    {
        var resultStringBuilder = new StringBuilder();

        var words = title.Split(' ');

        for (var i = 0; i < words.Length - 1; i++)
        {
            resultStringBuilder.Append(CapitalizeWord(words[i]));
            resultStringBuilder.Append(' ');
        }

        resultStringBuilder.Append(CapitalizeWord(words[^1]));

        return resultStringBuilder.ToString();
    }

    private static char[] CapitalizeWord(string word)
    {
        if (word.Length > 2)
        {
            var resultWord = new char[word.Length];

            resultWord[0] = char.ToUpper(word[0]);

            for (var i = 1; i < word.Length; i++)
            {
                resultWord[i] = char.ToLower(word[i]);
            }

            return resultWord;
        }
        else
        {
            var resultWord = new char[word.Length];

            for (var i = 0; i < word.Length; i++)
            {
                resultWord[i] = char.ToLower(word[i]);
            }

            return resultWord;
        }
    }
}