// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.ThreeFibonacciSum;

/// <inheritdoc />
public sealed class ThreeFibonacciSumSimulation : IThreeFibonacciSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool ThreeFibonacciSum(int n)
    {
        var second = 1;
        var third = 1;

        var sum = 2;

        while (sum < n)
        {
            var next = second + third;

            var first = second;

            second = third;
            third = next;

            sum = first + second + third;
        }

        return sum == n;
    }
}