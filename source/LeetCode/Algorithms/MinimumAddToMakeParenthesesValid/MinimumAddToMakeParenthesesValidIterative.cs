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

namespace LeetCode.Algorithms.MinimumAddToMakeParenthesesValid;

/// <inheritdoc />
public class MinimumAddToMakeParenthesesValidIterative : IMinimumAddToMakeParenthesesValid
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MinAddToMakeValid(string s)
    {
        var minAdd = 0;

        var openParenthesisCount = 0;

        foreach (var c in s)
        {
            if (c == '(')
            {
                openParenthesisCount++;

                minAdd++;
            }
            else
            {
                if (openParenthesisCount > 0)
                {
                    openParenthesisCount--;

                    minAdd--;
                }
                else
                {
                    minAdd++;
                }
            }
        }

        return Math.Abs(minAdd);
    }
}