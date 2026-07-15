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

namespace LeetCode.Algorithms.UniqueMiddleElement;

/// <inheritdoc />
public sealed class UniqueMiddleElementCounting : IUniqueMiddleElement
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool HasUniqueMiddleElement(int[] nums)
    {
        var n = nums.Length;
        var middleElement = nums[n / 2];

        var isMiddleElementUnique = true;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num != middleElement)
            {
                continue;
            }

            if (isMiddleElementUnique)
            {
                isMiddleElementUnique = false;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}