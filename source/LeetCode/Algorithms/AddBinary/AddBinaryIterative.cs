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

namespace LeetCode.Algorithms.AddBinary;

/// <summary>
///     https://leetcode.com/problems/add-binary/description/
/// </summary>
public static class AddBinaryIterative
{
    /// <summary>
    ///     Time complexity - O(max(n1, n2))
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static string GetResult(string a, string b)
    {
        var resultBuilder = new StringBuilder();

        var num1Index = a.Length - 1;
        var num2Index = b.Length - 1;

        var carry = 0;

        while (num1Index >= 0 || num2Index >= 0)
        {
            var val1 = 0;
            var val2 = 0;

            if (num1Index >= 0)
            {
                val1 = (int)char.GetNumericValue(a[num1Index]);
                num1Index--;
            }

            if (num2Index >= 0)
            {
                val2 = (int)char.GetNumericValue(b[num2Index]);
                num2Index--;
            }

            var sum = val1 + val2 + carry;

            if (sum >= 2)
            {
                sum -= 2;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            resultBuilder.Insert(0, sum);
        }

        if (carry > 0)
        {
            resultBuilder.Insert(0, carry);
        }

        return resultBuilder.ToString();
    }
}