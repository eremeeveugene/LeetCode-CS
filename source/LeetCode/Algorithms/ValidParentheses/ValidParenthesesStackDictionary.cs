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
public class ValidParenthesesStackDictionary : IValidParentheses
{
    private readonly Dictionary<char, char> _parenthesesDictionary = new() { { ')', '(' }, { '}', '{' }, { ']', '[' } };

    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool IsValid(string s)
    {
        var parenthesesStack = new Stack<char>();

        foreach (var c in s)
        {
            if (_parenthesesDictionary.TryGetValue(c, out var value))
            {
                if (parenthesesStack.Count == 0 || parenthesesStack.Pop() != value)
                {
                    return false;
                }
            }
            else
            {
                parenthesesStack.Push(c);
            }
        }

        return parenthesesStack.Count == 0;
    }
}