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

namespace LeetCode.Algorithms.ReverseWordsInString3;

/// <inheritdoc />
public sealed class ReverseWordsInString3WithCharArray : IReverseWordsInString3
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string ReverseWords(string s)
    {
        var words = s.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            var charArray = words[i].ToCharArray();

            Array.Reverse(charArray);

            words[i] = new string(charArray);
        }

        return string.Join(' ', words);
    }
}