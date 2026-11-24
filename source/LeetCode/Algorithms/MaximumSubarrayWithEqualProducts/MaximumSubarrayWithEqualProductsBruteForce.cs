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

namespace LeetCode.Algorithms.MaximumSubarrayWithEqualProducts;

/// <inheritdoc />
public sealed class MaximumSubarrayWithEqualProductsBruteForce : IMaximumSubarrayWithEqualProducts
{
    /// <summary>
    ///     The upper bound of lcm * gcd for values in [1, 10]: lcm(1..10) = 2520 and gcd is at most 10.
    /// </summary>
    private const int MaximumLcmGcdProduct = 25200;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 * log m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxLength(int[] nums)
    {
        var n = nums.Length;

        var maximumLength = 0;

        for (var left = 0; left < n; left++)
        {
            var product = 1;
            var gcd = 0;
            var lcm = 1;

            for (var right = left; right < n; right++)
            {
                var num = nums[right];

                product *= num;

                if (product > MaximumLcmGcdProduct)
                {
                    break;
                }

                gcd = GetGcd(gcd, num);
                lcm = GetLcm(lcm, num);

                if (product != lcm * gcd)
                {
                    continue;
                }

                var length = right - left + 1;

                maximumLength = Math.Max(maximumLength, length);
            }
        }

        return maximumLength;
    }

    /// <summary>
    ///     Computes the greatest common divisor of two non-negative integers.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <returns>The greatest common divisor of <paramref name="a" /> and <paramref name="b" />.</returns>
    /// <remarks>
    ///     Time complexity - O(log m)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetGcd(int a, int b)
    {
        while (b > 0)
        {
            (a, b) = (b, a % b);
        }

        return a;
    }

    /// <summary>
    ///     Computes the least common multiple of two positive integers.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <returns>The least common multiple of <paramref name="a" /> and <paramref name="b" />.</returns>
    /// <remarks>
    ///     Time complexity - O(log m)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetLcm(int a, int b)
    {
        var gcd = GetGcd(a, b);

        return a / gcd * b;
    }
}