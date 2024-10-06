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

namespace LeetCode.Algorithms.CapitalizeTheTitle;

/// <inheritdoc />
public class CapitalizeTheTitleArray : ICapitalizeTheTitle
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="title"></param>
    /// <returns></returns>
    public string CapitalizeTitle(string title)
    {
        var words = title.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 2)
            {
                words[i] = words[i].ToLower();
            }
            else
            {
                words[i] = char.ToUpper(words[i][0]) + words[i][1..].ToLower();
            }
        }

        return string.Join(' ', words);
    }
}