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

namespace LeetCode.Algorithms.NthTribonacciNumber;

/// <inheritdoc />
public class NthTribonacciNumberIterative : INthTribonacciNumber
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Tribonacci(int n)
    {
        switch (n)
        {
            case 0:
                return 0;
            case 1:
            case 2:
                return 1;
        }

        var a = 0;
        var b = 1;
        var c = 1;

        for (var i = 3; i <= n; i++)
        {
            var d = a + b + c;
            a = b;
            b = c;
            c = d;
        }

        return c;
    }
}