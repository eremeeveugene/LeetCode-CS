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

namespace LeetCode.Algorithms.RemoveOutermostParentheses;

/// <inheritdoc />
public sealed class RemoveOutermostParenthesesSpanBuffer : IRemoveOutermostParentheses
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string RemoveOuterParentheses(string s)
    {
        var n = s.Length;

        Span<char> buffer = stackalloc char[n];

        var length = 0;
        var depth = 0;

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            if (c == '(')
            {
                if (depth > 0)
                {
                    buffer[length] = c;

                    length++;
                }

                depth++;
            }
            else
            {
                depth--;

                if (depth <= 0)
                {
                    continue;
                }

                buffer[length] = c;

                length++;
            }
        }

        return new string(buffer[..length]);
    }
}