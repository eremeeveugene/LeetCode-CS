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

namespace LeetCode.Algorithms.MaximumDistanceBetweenPairOfValues;

/// <inheritdoc />
public sealed class MaximumDistanceBetweenPairOfValuesTwoPointers : IMaximumDistanceBetweenPairOfValues
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxDistance(int[] nums1, int[] nums2)
    {
        var maxDistance = 0;

        var i = 0;
        var j = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] > nums2[j])
            {
                i++;
            }
            else
            {
                var distance = j - i;

                maxDistance = Math.Max(maxDistance, distance);

                j++;
            }
        }

        return maxDistance;
    }
}