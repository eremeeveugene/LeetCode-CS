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

namespace LeetCode.Algorithms.FindGreatestCommonDivisorOfArray;

/// <inheritdoc />
public sealed class FindGreatestCommonDivisorOfArrayEuclidean : IFindGreatestCommonDivisorOfArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + log m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindGCD(int[] nums)
    {
        var min = int.MaxValue;
        var max = int.MinValue;

        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        return GetGcd(min, max);
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