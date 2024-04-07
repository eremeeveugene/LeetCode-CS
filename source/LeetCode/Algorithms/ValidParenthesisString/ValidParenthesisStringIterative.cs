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

namespace LeetCode.Algorithms.ValidParenthesisString;

/// <inheritdoc />
public class ValidParenthesisStringIterative : IValidParenthesisString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool CheckValidString(string s)
    {
        var minLeftCount = 0;
        var maxLeftCount = 0;

        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                    minLeftCount++;
                    maxLeftCount++;
                    break;
                case ')':
                    {
                        if (minLeftCount > 0)
                        {
                            minLeftCount--;
                        }

                        maxLeftCount--;

                        if (maxLeftCount < 0)
                        {
                            return false;
                        }

                        break;
                    }
                case '*':
                    {
                        if (minLeftCount > 0)
                        {
                            minLeftCount--;
                        }

                        maxLeftCount++;
                        break;
                    }
            }
        }

        return minLeftCount == 0;
    }
}