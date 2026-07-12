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

namespace LeetCode.Algorithms.ValidTriangleNumber;

/// <inheritdoc />
public sealed class ValidTriangleNumberSortingTwoPointers : IValidTriangleNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity -  O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int TriangleNumber(int[] nums)
    {
        var numsLength = nums.Length;

        if (numsLength < 3)
        {
            return 0;
        }

        Array.Sort(nums);

        var count = 0;

        for (var cIndex = numsLength - 1; cIndex > 1; cIndex--)
        {
            var aIndex = 0;
            var bIndex = cIndex - 1;

            while (aIndex < bIndex)
            {
                var a = nums[aIndex];
                var b = nums[bIndex];
                var c = nums[cIndex];

                if (a + b > c)
                {
                    count += bIndex - aIndex;

                    bIndex--;
                }
                else
                {
                    aIndex++;
                }
            }
        }

        return count;
    }
}