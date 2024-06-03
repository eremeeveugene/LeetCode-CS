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

namespace LeetCode.Algorithms.ReverseWordsInString3;

/// <inheritdoc />
public class ReverseWordsInString3WithStringBuilder : IReverseWordsInString3
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string ReverseWords(string s)
    {
        var words = s.Split(' ');

        var reverseWordsBuilder = new StringBuilder();

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            for (var j = word.Length - 1; j >= 0; j--)
            {
                reverseWordsBuilder.Append(word[j]);
            }

            if (i < words.Length - 1)
            {
                reverseWordsBuilder.Append(' ');
            }
        }

        return reverseWordsBuilder.ToString();
    }
}