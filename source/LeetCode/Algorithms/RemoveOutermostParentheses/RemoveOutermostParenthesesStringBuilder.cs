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
public sealed class RemoveOutermostParenthesesStringBuilder : IRemoveOutermostParentheses
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string RemoveOuterParentheses(string s)
    {
        var n = s.Length;

        var stringBuilder = new StringBuilder(n);

        var depth = 0;

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            if (c == '(')
            {
                if (depth > 0)
                {
                    stringBuilder.Append(c);
                }

                depth++;
            }
            else
            {
                depth--;

                if (depth > 0)
                {
                    stringBuilder.Append(c);
                }
            }
        }

        return stringBuilder.ToString();
    }
}