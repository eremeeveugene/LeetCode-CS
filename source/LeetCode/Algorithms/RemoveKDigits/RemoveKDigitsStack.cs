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

namespace LeetCode.Algorithms.RemoveKDigits;

/// <inheritdoc />
public class RemoveKDigitsStack : IRemoveKDigits
{
    public string RemoveKdigits(string num, int k)
    {
        var stack = new Stack<char>();

        foreach (var digit in num)
        {
            while (k > 0 && stack.Count > 0 && stack.Peek() > digit)
            {
                stack.Pop();

                k--;
            }

            stack.Push(digit);
        }

        while (k > 0 && stack.Count > 0)
        {
            stack.Pop();

            k--;
        }

        var stringBuilder = new StringBuilder();

        while (stack.Count > 0)
        {
            stringBuilder.Insert(0, stack.Pop());
        }

        var result = stringBuilder.ToString().TrimStart('0');

        return string.IsNullOrEmpty(result) ? "0" : result;
    }
}