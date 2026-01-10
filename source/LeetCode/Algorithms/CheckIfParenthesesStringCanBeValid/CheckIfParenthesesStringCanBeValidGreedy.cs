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

namespace LeetCode.Algorithms.CheckIfParenthesesStringCanBeValid;

/// <inheritdoc />
public sealed class CheckIfParenthesesStringCanBeValidGreedy : ICheckIfParenthesesStringCanBeValid
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="locked"></param>
    /// <returns></returns>
    public bool CanBeValid(string s, string locked)
    {
        if (s.Length % 2 == 1)
        {
            return false;
        }

        var openMin = 0;
        var openMax = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (locked[i] == '0')
            {
                openMax++;
                openMin = Math.Max(0, openMin - 1);
            }
            else if (s[i] == '(')
            {
                openMax++;
                openMin++;
            }
            else
            {
                openMax--;
                openMin = Math.Max(0, openMin - 1);
            }

            if (openMax < 0)
            {
                return false;
            }
        }

        return openMin == 0;
    }
}