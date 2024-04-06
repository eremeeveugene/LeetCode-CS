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

using System.Text;

namespace LeetCode.Algorithms.MinimumRemoveToMakeValidParentheses;

/// <inheritdoc />
public class MinimumRemoveToMakeValidParenthesesStringBuilder : IMinimumRemoveToMakeValidParentheses
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string MinRemoveToMakeValid(string s)
    {
        var leftStringBuilder = new StringBuilder();

        var leftCount = 0;

        foreach (var c in s)
        {
            switch (c)
            {
                case ')':
                    {
                        if (leftCount > 0)
                        {
                            leftCount--;
                            leftStringBuilder.Append(c);
                        }

                        break;
                    }
                case '(':
                    leftStringBuilder.Append(c);

                    leftCount++;
                    break;
                default:
                    leftStringBuilder.Append(c);
                    break;
            }
        }

        var rightStringBuilder = new StringBuilder();

        var rightCount = 0;

        for (var i = leftStringBuilder.ToString().Length - 1; i >= 0; i--)
        {
            switch (leftStringBuilder[i])
            {
                case '(':
                    {
                        if (rightCount > 0)
                        {
                            rightCount--;
                            rightStringBuilder.Insert(0, leftStringBuilder[i]);
                        }

                        break;
                    }
                case ')':
                    rightStringBuilder.Insert(0, leftStringBuilder[i]);

                    rightCount++;
                    break;
                default:
                    rightStringBuilder.Insert(0, leftStringBuilder[i]);
                    break;
            }
        }

        return rightStringBuilder.ToString();
    }
}