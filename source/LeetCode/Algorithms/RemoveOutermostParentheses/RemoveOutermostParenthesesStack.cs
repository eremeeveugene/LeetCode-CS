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

using System.Text;

namespace LeetCode.Algorithms.RemoveOutermostParentheses;

/// <inheritdoc />
public sealed class RemoveOutermostParenthesesStack : IRemoveOutermostParentheses
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string RemoveOuterParentheses(string s)
    {
        var stringBuilder = new StringBuilder(s.Length);

        var stack = new Stack<char>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (c == '(')
            {
                if (stack.Count > 0)
                {
                    stringBuilder.Append(c);
                }

                stack.Push(c);
            }
            else
            {
                stack.Pop();

                if (stack.Count > 0)
                {
                    stringBuilder.Append(c);
                }
            }
        }

        return stringBuilder.ToString();
    }
}