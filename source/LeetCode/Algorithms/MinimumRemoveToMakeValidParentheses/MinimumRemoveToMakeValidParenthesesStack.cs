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
public class MinimumRemoveToMakeValidParenthesesStack : IMinimumRemoveToMakeValidParentheses
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string MinRemoveToMakeValid(string s)
    {
        var removeIndices = new HashSet<int>();
        var stack = new Stack<int>();

        for (var i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                    stack.Push(i);
                    break;
                case ')' when stack.Count > 0:
                    stack.Pop();
                    break;
                case ')':
                    removeIndices.Add(i);
                    break;
            }
        }

        while (stack.Count > 0)
        {
            removeIndices.Add(stack.Pop());
        }

        var resultBuilder = new StringBuilder();

        for (var i = 0; i < s.Length; i++)
        {
            if (!removeIndices.Contains(i))
            {
                resultBuilder.Append(s[i]);
            }
        }

        return resultBuilder.ToString();
    }
}