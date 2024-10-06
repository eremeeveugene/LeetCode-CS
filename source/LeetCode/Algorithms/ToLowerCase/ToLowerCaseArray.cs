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

namespace LeetCode.Algorithms.ToLowerCase;

/// <inheritdoc />
public class ToLowerCaseArray : IToLowerCase
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string ToLowerCase(string s)
    {
        var result = new char[s.Length];

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
            {
                result[i] = (char)(s[i] + 32);
            }
            else
            {
                result[i] = s[i];
            }
        }

        return string.Join("", result);
    }
}