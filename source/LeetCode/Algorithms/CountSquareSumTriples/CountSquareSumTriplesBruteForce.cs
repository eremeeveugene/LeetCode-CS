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

namespace LeetCode.Algorithms.CountSquareSumTriples;

/// <inheritdoc />
public sealed class CountSquareSumTriplesBruteForce : ICountSquareSumTriples
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int CountTriples(int n)
    {
        var count = 0;

        for (var a = 1; a < n; a++)
        {
            for (var b = a + 1; b < n; b++)
            {
                var sum = (a * a) + (b * b);

                var c = (int)Math.Sqrt(sum);

                if (c > n)
                {
                    break;
                }

                if (c * c == sum)
                {
                    count += 2;
                }
            }
        }

        return count;
    }
}