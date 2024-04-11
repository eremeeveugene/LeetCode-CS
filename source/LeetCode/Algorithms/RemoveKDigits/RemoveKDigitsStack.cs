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

namespace LeetCode.Algorithms.RemoveKDigits;

/// <inheritdoc />
public class RemoveKDigitsStack : IRemoveKDigits
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="num"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public string RemoveKdigits(string num, int k)
    {
        if (k == num.Length)
        {
            return "0";
        }

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

        var resultArray = stack.ToArray();

        Array.Reverse(resultArray);

        var startIndex = 0;

        while (startIndex < resultArray.Length && resultArray[startIndex] == '0')
        {
            startIndex++;
        }

        return startIndex == resultArray.Length
            ? "0"
            : new string(resultArray, startIndex, resultArray.Length - startIndex);
    }
}