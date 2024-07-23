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

namespace LeetCode.Algorithms.ReverseSubstringsBetweenEachPairOfParentheses;

/// <inheritdoc />
public class ReverseSubstringsBetweenEachPairOfParenthesesStack : IReverseSubstringsBetweenEachPairOfParentheses
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string ReverseParentheses(string s)
    {
        var leftParenthesesIndexStack = new Stack<int>();

        var sArray = s.ToCharArray();

        for (var i = 0; i < sArray.Length; i++)
        {
            switch (sArray[i])
            {
                case '(':
                    leftParenthesesIndexStack.Push(i);
                    break;
                case ')':
                    {
                        var left = leftParenthesesIndexStack.Pop() + 1;
                        var right = i - 1;

                        while (left < right)
                        {
                            (sArray[left], sArray[right]) = (sArray[right], sArray[left]);

                            left++;
                            right--;
                        }

                        break;
                    }
            }
        }

        var stringBuilder = new StringBuilder();

        foreach (var c in sArray)
        {
            if (c != '(' && c != ')')
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString();
    }
}