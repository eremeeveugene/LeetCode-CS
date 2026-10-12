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

namespace LeetCode.Algorithms.MinimumInsertionsToBalanceAParenthesesString;

/// <inheritdoc />
public sealed class MinimumInsertionsToBalanceAParenthesesStringGreedy : IMinimumInsertionsToBalanceAParenthesesString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinInsertions(string s)
    {
        var insertions = 0;
        var neededClosing = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (c == '(')
            {
                if (neededClosing % 2 == 1)
                {
                    insertions++;

                    neededClosing--;
                }

                neededClosing += 2;
            }
            else
            {
                neededClosing--;

                if (neededClosing < 0)
                {
                    insertions++;

                    neededClosing += 2;
                }
            }
        }

        return insertions + neededClosing;
    }
}