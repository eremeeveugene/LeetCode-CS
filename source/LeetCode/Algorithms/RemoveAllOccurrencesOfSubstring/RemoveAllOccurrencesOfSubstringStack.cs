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

namespace LeetCode.Algorithms.RemoveAllOccurrencesOfSubstring;

/// <inheritdoc />
public sealed class RemoveAllOccurrencesOfSubstringStack : IRemoveAllOccurrencesOfSubstring
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string RemoveOccurrences(string s, string part)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            stack.Push(c);

            if (stack.Count < part.Length)
            {
                continue;
            }

            var tempStack = new Stack<char>();

            for (var i = part.Length - 1; i >= 0; i--)
            {
                if (stack.Peek() == part[i])
                {
                    tempStack.Push(stack.Pop());
                }
                else
                {
                    while (tempStack.Count > 0)
                    {
                        stack.Push(tempStack.Pop());
                    }

                    break;
                }
            }
        }

        var result = new char[stack.Count];

        for (var i = result.Length - 1; i >= 0; i--)
        {
            result[i] = stack.Pop();
        }

        return new string(result);
    }
}