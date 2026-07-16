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

namespace LeetCode.Algorithms.SumOfGcdOfFormedPairs;

/// <inheritdoc />
public sealed class SumOfGcdOfFormedPairsSimulation : ISumOfGcdOfFormedPairs
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * (log n + log m))
    ///     Space complexity - O(n)
    /// </remarks>
    public long GcdSum(int[] nums)
    {
        Span<int> prefixGcd = stackalloc int[nums.Length];

        var max = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            max = Math.Max(max, num);

            prefixGcd[i] = GetGcd(num, max);
        }

        prefixGcd.Sort();

        long sum = 0;

        var left = 0;
        var right = prefixGcd.Length - 1;

        while (left < right)
        {
            sum += GetGcd(prefixGcd[left], prefixGcd[right]);

            left++;
            right--;
        }

        return sum;
    }

    private static int GetGcd(int a, int b)
    {
        while (b > 0)
        {
            (a, b) = (b, a % b);
        }

        return a;
    }
}