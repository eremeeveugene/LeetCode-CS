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
public sealed class MaximumDistanceBetweenPairOfValuesBruteForce : IMaximumDistanceBetweenPairOfValues
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxDistance(int[] nums1, int[] nums2)
    {
        var maxDistance = 0;

        for (var i = 0; i < nums1.Length; i++)
        {
            var num1 = nums1[i];

            var distance = 0;

            for (var j = i; j < nums2.Length; j++)
            {
                var num2 = nums2[j];

                if (num1 > num2)
                {
                    break;
                }

                distance = j - i;
            }

            maxDistance = Math.Max(maxDistance, distance);
        }

        return maxDistance;
    }
}