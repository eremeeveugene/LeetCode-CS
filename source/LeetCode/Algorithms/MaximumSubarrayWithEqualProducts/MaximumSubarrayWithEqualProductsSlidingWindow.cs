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
///     window in which no prime divides two elements, but at least two. The window starts right after the last
///     occurrence of any prime dividing the current element.
/// </remarks>
public sealed class MaximumSubarrayWithEqualProductsSlidingWindow : IMaximumSubarrayWithEqualProducts
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

        Span<int> lastPrimeIndexes = stackalloc int[Primes.Length];

        lastPrimeIndexes.Fill(-1);

        var maximumLength = 2;

        var left = 0;

        for (var right = 0; right < n; right++)
        {
            var num = nums[right];

            for (var i = 0; i < Primes.Length; i++)
            {
                var prime = Primes[i];

                if (num % prime != 0)
                {
                    continue;
                }

                left = Math.Max(left, lastPrimeIndexes[i] + 1);

                lastPrimeIndexes[i] = right;
            }

            var length = right - left + 1;

            maximumLength = Math.Max(maximumLength, length);
        }

        return maximumLength;
    }
}