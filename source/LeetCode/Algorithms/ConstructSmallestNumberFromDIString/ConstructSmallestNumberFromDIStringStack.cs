// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using System.Text;

namespace LeetCode.Algorithms.ConstructSmallestNumberFromDIString;

/// <inheritdoc />
public class ConstructSmallestNumberFromDIStringStack : IConstructSmallestNumberFromDIString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="pattern"></param>
    /// <returns></returns>
    public string SmallestNumber(string pattern)
    {
        var stringBuilder = new StringBuilder();
        var stack = new Stack<int>();

        for (var i = 0; i <= pattern.Length; i++)
        {
            stack.Push(i + 1);

            if (i != pattern.Length && pattern[i] != 'I')
            {
                continue;
            }

            while (stack.Count > 0)
            {
                stringBuilder.Append(stack.Pop());
            }
        }

        return stringBuilder.ToString();
    }
}