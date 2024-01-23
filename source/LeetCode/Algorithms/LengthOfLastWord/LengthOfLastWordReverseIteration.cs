﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.LengthOfLastWord;

/// <inheritdoc />
public class LengthOfLastWordReverseIteration : ILengthOfLastWord
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LengthOfLastWord(string s)
    {
        var length = 0;
        var wordStarted = false;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                wordStarted = true;
                length++;
            }
            else if (wordStarted)
            {
                break;
            }
        }

        return length;
    }
}