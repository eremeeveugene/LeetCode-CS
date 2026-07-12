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

namespace LeetCode.Algorithms.LargestPerimeterTriangle;

/// <inheritdoc />
public sealed class LargestPerimeterTriangleSorting : ILargestPerimeterTriangle
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int LargestPerimeter(int[] nums)
    {
        var numsLength = nums.Length;

        if (numsLength < 3)
        {
            return 0;
        }

        Array.Sort(nums, NumsComparison);

        for (var i = numsLength - 3; i >= 0; i--)
        {
            var a = nums[i];
            var b = nums[i + 1];
            var c = nums[i + 2];

            if (a + b > c)
            {
                return a + b + c;
            }
        }

        return 0;
    }

    private static int NumsComparison(int x, int y)
    {
        return x - y;
    }
}