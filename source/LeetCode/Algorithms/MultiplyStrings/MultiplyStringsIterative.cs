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

namespace LeetCode.Algorithms.MultiplyStrings;

/// <inheritdoc />
public class MultiplyStringsIterative : IMultiplyStrings
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
        {
            return "0";
        }

        var result = new int[num1.Length + num2.Length];

        for (var i = num1.Length - 1; i >= 0; i--)
        {
            for (var j = num2.Length - 1; j >= 0; j--)
            {
                var product = (int)char.GetNumericValue(num1[i]) * (int)char.GetNumericValue(num2[j]);
                var p1 = i + j;
                var p2 = i + j + 1;
                var sum = product + result[p2];

                result[p1] += sum / 10;
                result[p2] = sum % 10;
            }
        }

        var resultStringBuilder = new StringBuilder();

        foreach (var num in result)
        {
            if (!(resultStringBuilder.Length == 0 && num == 0))
            {
                resultStringBuilder.Append(num);
            }
        }

        return resultStringBuilder.Length == 0 ? "0" : resultStringBuilder.ToString();
    }
}