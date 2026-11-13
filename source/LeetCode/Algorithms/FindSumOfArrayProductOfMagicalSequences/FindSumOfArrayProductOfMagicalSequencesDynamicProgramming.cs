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

using System.Numerics;

namespace LeetCode.Algorithms.FindSumOfArrayProductOfMagicalSequences;

/// <inheritdoc />
public sealed class FindSumOfArrayProductOfMagicalSequencesDynamicProgramming : IFindSumOfArrayProductOfMagicalSequences
{
    private const int Modulo = 1_000_000_007;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m^3 * k)
    ///     Space complexity - O(m^2 * k)
    /// </remarks>
    public int MagicalSum(int m, int k, int[] nums)
    {
        var n = nums.Length;
        var maxCarry = m / 2;
        var binomialCoefficients = GetBinomialCoefficients(m);
        var ways = new long[m + 1, maxCarry + 1, k + 1];
        var nextWays = new long[m + 1, maxCarry + 1, k + 1];

        Span<long> powers = stackalloc long[m + 1];

        ways[0, 0, 0] = 1;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            powers[0] = 1;

            for (var count = 1; count <= m; count++)
            {
                powers[count] = powers[count - 1] * num % Modulo;
            }

            Array.Clear(nextWays);

            for (var used = 0; used <= m; used++)
            {
                var remaining = m - used;

                for (var carry = 0; carry <= maxCarry; carry++)
                {
                    for (var setBits = 0; setBits <= k; setBits++)
                    {
                        var currentWays = ways[used, carry, setBits];

                        if (currentWays == 0)
                        {
                            continue;
                        }

                        for (var count = 0; count <= remaining; count++)
                        {
                            var total = carry + count;
                            var nextSetBits = setBits + (total & 1);

                            if (nextSetBits > k)
                            {
                                continue;
                            }

                            var nextUsed = used + count;
                            var nextCarry = total >> 1;
                            var binomialCoefficient = binomialCoefficients[remaining, count];
                            var power = powers[count];
                            var contribution = currentWays * binomialCoefficient % Modulo * power % Modulo;

                            nextWays[nextUsed, nextCarry, nextSetBits] =
                                (nextWays[nextUsed, nextCarry, nextSetBits] + contribution) % Modulo;
                        }
                    }
                }
            }

            (ways, nextWays) = (nextWays, ways);
        }

        long result = 0;

        for (var carry = 0; carry <= maxCarry; carry++)
        {
            var carrySetBits = BitOperations.PopCount((uint)carry);
            var setBits = k - carrySetBits;

            if (setBits < 0)
            {
                continue;
            }

            var currentWays = ways[m, carry, setBits];

            result = (result + currentWays) % Modulo;
        }

        return (int)result;
    }

    /// <summary>
    ///     Builds Pascal's triangle of binomial coefficients C(row, column) for all rows up to
    ///     <paramref name="size" />.
    /// </summary>
    /// <param name="size">The largest row of the triangle to build.</param>
    /// <returns>The table where the cell [row, column] holds C(row, column).</returns>
    /// <remarks>
    ///     Time complexity - O(size^2)
    ///     Space complexity - O(size^2)
    /// </remarks>
    private static long[,] GetBinomialCoefficients(int size)
    {
        var binomialCoefficients = new long[size + 1, size + 1];

        for (var row = 0; row <= size; row++)
        {
            binomialCoefficients[row, 0] = 1;

            for (var column = 1; column <= row; column++)
            {
                binomialCoefficients[row, column] =
                    binomialCoefficients[row - 1, column - 1] + binomialCoefficients[row - 1, column];
            }
        }

        return binomialCoefficients;
    }
}