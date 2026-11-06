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

namespace LeetCode.Algorithms.MinimumValueOfMergedIntegers;

/// <inheritdoc />
public sealed class MinimumValueOfMergedIntegersMath : IMinimumValueOfMergedIntegers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * log m), where n is the length of nums and m is the maximum value in nums
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinMergedInteger(int[] nums)
    {
        var n = nums.Length;

        var result = int.MaxValue;

        for (var i = 0; i < n; i += 2)
        {
            var first = nums[i];
            var second = nums[i + 1];

            var merged = Merge(first, second);

            result = Math.Min(result, merged);
        }

        return result;
    }

    /// <summary>
    ///     Concatenates the decimal digits of <paramref name="first" /> and <paramref name="second" /> arithmetically.
    /// </summary>
    /// <param name="first">The integer that provides the leading digits.</param>
    /// <param name="second">The integer that provides the trailing digits.</param>
    /// <returns>The merged integer.</returns>
    /// <remarks>
    ///     Time complexity - O(log m), where m is the value of second
    ///     Space complexity - O(1)
    /// </remarks>
    private static int Merge(int first, int second)
    {
        var multiplier = 1;

        var remaining = second;

        while (remaining > 0)
        {
            multiplier *= 10;

            remaining /= 10;
        }

        return (first * multiplier) + second;
    }
}