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

using System.Numerics;

namespace LeetCode.Algorithms.MultiplyStrings;

/// <inheritdoc />
public class MultiplyStringsBigInteger : IMultiplyStrings
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
        var n1 = BigInteger.Parse(num1);
        var n2 = BigInteger.Parse(num2);

        var result = n1 * n2;

        return result.ToString();
    }
}