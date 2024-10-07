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

namespace LeetCode.Algorithms.MinimumStringLengthAfterRemovingSubstrings;

/// <inheritdoc />
public class MinimumStringLengthAfterRemovingSubstringsStack : IMinimumStringLengthAfterRemovingSubstrings
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MinLength(string s)
    {
        var minLength = s.Length;

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            switch (c)
            {
                case 'B' when stack.Count > 0 && stack.Peek() == 'A':
                    stack.Pop();

                    minLength -= 2;

                    break;
                case 'D' when stack.Count > 0 && stack.Peek() == 'C':
                    stack.Pop();

                    minLength -= 2;

                    break;
                default:
                    stack.Push(c);

                    break;
            }
        }

        return minLength;
    }
}