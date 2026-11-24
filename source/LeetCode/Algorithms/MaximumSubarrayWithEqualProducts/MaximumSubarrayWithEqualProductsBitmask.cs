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
/// <remarks>
///     Any two-element subarray is product equivalent (a * b = lcm(a, b) * gcd(a, b)). A subarray of three or more
///     elements is product equivalent exactly when its elements are pairwise coprime, so the answer is the longest
///     window whose elements share no prime factor, but at least two.
/// </remarks>
public sealed class MaximumSubarrayWithEqualProductsBitmask : IMaximumSubarrayWithEqualProducts
{
    private static readonly int[] Primes = [2, 3, 5, 7];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxLength(int[] nums)
    {
        var n = nums.Length;

        var maximumLength = 2;

        var windowPrimesMask = 0;
        var left = 0;

        for (var right = 0; right < n; right++)
        {
            var num = nums[right];

            var numPrimesMask = GetPrimesMask(num);

            while ((windowPrimesMask & numPrimesMask) != 0)
            {
                var leftNum = nums[left];

                var leftNumPrimesMask = GetPrimesMask(leftNum);

                windowPrimesMask &= ~leftNumPrimesMask;

                left++;
            }

            windowPrimesMask |= numPrimesMask;

            var length = right - left + 1;

            maximumLength = Math.Max(maximumLength, length);
        }

        return maximumLength;
    }

    /// <summary>
    ///     Builds a bitmask of the prime factors of <paramref name="num" />, one bit per prime up to 7.
    /// </summary>
    /// <param name="num">The integer in the range [1, 10].</param>
    /// <returns>The bitmask whose i-th bit is set when the i-th prime divides <paramref name="num" />.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetPrimesMask(int num)
    {
        var primesMask = 0;

        for (var i = 0; i < Primes.Length; i++)
        {
            var prime = Primes[i];

            if (num % prime != 0)
            {
                continue;
            }

            primesMask |= 1 << i;
        }

        return primesMask;
    }
}