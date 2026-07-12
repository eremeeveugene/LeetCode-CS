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

namespace LeetCode.Algorithms.ReplaceNonCoprimeNumbersInArray;

/// <inheritdoc />
public sealed class ReplaceNonCoprimeNumbersInArrayGreedy : IReplaceNonCoprimeNumbersInArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log M), where n is the length of nums and M is max(nums[i])
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> ReplaceNonCoprimes(int[] nums)
    {
        var top = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            var x = nums[i];

            while (top >= 0)
            {
                var y = nums[top];

                var greatestCommonDivisor = GetGreatestCommonDivisor(x, y);

                if (!IsNonComprime(greatestCommonDivisor))
                {
                    break;
                }

                x = GetLeastCommonMultiple(x, y, greatestCommonDivisor);

                top--;
            }

            top++;

            nums[top] = x;
        }

        var resultLength = top + 1;

        var result = new List<int>(resultLength);

        for (var i = 0; i < resultLength; i++)
        {
            result.Add(nums[i]);
        }

        return result;
    }

    /// <summary>
    ///     Determines whether the given <paramref name="greatestCommonDivisor" /> indicates two non-coprime numbers.
    /// </summary>
    /// <param name="greatestCommonDivisor">The greatest common divisor of two numbers.</param>
    /// <returns><see langword="true" /> if the numbers are non-coprime; otherwise, <see langword="false" />.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsNonComprime(int greatestCommonDivisor)
    {
        return greatestCommonDivisor > 1;
    }

    /// <summary>
    ///     Computes the greatest common divisor of <paramref name="x" /> and <paramref name="y" /> using the Euclidean
    ///     algorithm.
    /// </summary>
    /// <param name="x">The first number.</param>
    /// <param name="y">The second number.</param>
    /// <returns>The greatest common divisor of the two numbers.</returns>
    /// <remarks>
    ///     Time complexity - O(log(min(x, y)))
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetGreatestCommonDivisor(int x, int y)
    {
        while (y != 0)
        {
            var temp = y;

            y = x % y;

            x = temp;
        }

        return int.Abs(x);
    }

    /// <summary>
    ///     Computes the least common multiple of <paramref name="x" /> and <paramref name="y" /> using their precomputed
    ///     <paramref name="greatestCommonDivisor" />.
    /// </summary>
    /// <param name="x">The first number.</param>
    /// <param name="y">The second number.</param>
    /// <param name="greatestCommonDivisor">The greatest common divisor of the two numbers.</param>
    /// <returns>The least common multiple of the two numbers.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetLeastCommonMultiple(int x, int y, int greatestCommonDivisor)
    {
        return int.Abs(x / greatestCommonDivisor * y);
    }
}