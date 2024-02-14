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

namespace LeetCode.Algorithms.RepeatedSubstringPattern;

/// <inheritdoc />
public class RepeatedSubstringPatternIterative : IRepeatedSubstringPattern
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool RepeatedSubstringPattern(string s)
    {
        for (var i = 1; i < s.Length; i++)
        {
            if (s.Length % i != 0)
            {
                continue;
            }

            if (s.Where((t, j) => t != s[..i][j % i]).Any())
            {
                continue;
            }

            return true;
        }

        return false;
    }
}