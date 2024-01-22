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
public class ValidParentheses1 : IValidParentheses
{
    public bool IsValid(string s)
    {
        var charsQueue = new Stack<char>();

        foreach (var c in s)
        {
            if (charsQueue.Count == 0)
            {
                charsQueue.Push(c);
            }
            else
            {
                switch (charsQueue.Peek())
                {
                    case '(' when c == ')':
                    case '{' when c == '}':
                    case '[' when c == ']':
                        charsQueue.Pop();
                        break;
                    case '(':
                    case '{':
                    case '[':
                        charsQueue.Push(c);
                        break;
                }
            }
        }

        return charsQueue.Count == 0;
    }
}