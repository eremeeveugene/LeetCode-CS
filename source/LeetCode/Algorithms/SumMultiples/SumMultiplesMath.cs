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

namespace LeetCode.Algorithms.SumMultiples;

/// <inheritdoc />
public class SumMultiplesMath : ISumMultiples
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int SumOfMultiples(int n)
    {
        var sum = 0;

        sum += SumDivisibleBy(n, 3);
        sum += SumDivisibleBy(n, 5);
        sum += SumDivisibleBy(n, 7);

        sum -= SumDivisibleBy(n, 3 * 5);
        sum -= SumDivisibleBy(n, 3 * 7);
        sum -= SumDivisibleBy(n, 5 * 7);

        sum += SumDivisibleBy(n, 3 * 5 * 7);

        return sum;
    }

    private static int SumDivisibleBy(int n, int d)
    {
        var p = n / d;

        return d * p * (p + 1) / 2;
    }
}