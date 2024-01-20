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

namespace LeetCode.Algorithms.ReverseString;

/// <inheritdoc />
public class ReverseStringTwoPointers : IReverseString
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    public void ReverseString(char[] s)
    {
        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            (s[i], s[j]) = (s[j], s[i]);
        }
    }
}