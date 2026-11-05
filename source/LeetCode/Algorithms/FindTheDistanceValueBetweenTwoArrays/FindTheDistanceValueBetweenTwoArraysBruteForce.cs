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

namespace LeetCode.Algorithms.FindTheDistanceValueBetweenTwoArrays;

/// <inheritdoc />
public sealed class FindTheDistanceValueBetweenTwoArraysBruteForce : IFindTheDistanceValueBetweenTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m), where n is the length of arr1 and m is the length of arr2
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        var n = arr1.Length;

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var value = arr1[i];

            var isWithinDistance = IsWithinDistance(arr2, value, d);

            if (isWithinDistance)
            {
                continue;
            }

            result++;
        }

        return result;
    }

    /// <summary>
    ///     Determines whether any element of <paramref name="nums" /> is within an absolute difference of at most
    ///     <paramref name="d" /> from <paramref name="value" />.
    /// </summary>
    /// <param name="nums">The array of integers to compare against.</param>
    /// <param name="value">The value to compare.</param>
    /// <param name="d">The maximum absolute difference.</param>
    /// <returns><c>true</c> if such an element exists; otherwise, <c>false</c>.</returns>
    /// <remarks>
    ///     Time complexity - O(m), where m is the length of nums
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsWithinDistance(int[] nums, int value, int d)
    {
        var m = nums.Length;

        for (var i = 0; i < m; i++)
        {
            var num = nums[i];

            if (Math.Abs(value - num) <= d)
            {
                return true;
            }
        }

        return false;
    }
}