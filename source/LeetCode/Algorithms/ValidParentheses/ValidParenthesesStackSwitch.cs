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

namespace LeetCode.Algorithms.ValidParentheses;

/// <inheritdoc />
public class ValidParenthesesStackSwitch : IValidParentheses
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool IsValid(string s)
    {
        var parenthesesStack = new Stack<char>();

        foreach (var c in s)
        {
            if (parenthesesStack.Count == 0)
            {
                parenthesesStack.Push(c);
            }
            else
            {
                switch (parenthesesStack.Peek())
                {
                    case '(' when c == ')':
                    case '{' when c == '}':
                    case '[' when c == ']':
                        parenthesesStack.Pop();
                        break;
                    case '(':
                    case '{':
                    case '[':
                        parenthesesStack.Push(c);
                        break;
                }
            }
        }

        return parenthesesStack.Count == 0;
    }
}