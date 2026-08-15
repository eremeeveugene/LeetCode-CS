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

namespace LeetCode.Algorithms.MedianOfTwoSortedArrays;

/// <inheritdoc />
public sealed class MedianOfTwoSortedArraysBinarySearch : IMedianOfTwoSortedArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log min(n,m))
    ///     Space complexity - O(1)
    /// </remarks>
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            (nums1, nums2) = (nums2, nums1);
        }

        var low = 0;
        var high = nums1.Length;
        var halfLen = (nums1.Length + nums2.Length + 1) / 2;

        var result = 0.0;

        while (low <= high)
        {
            var i = (low + high) / 2;
            var j = halfLen - i;

            if (i < nums1.Length && nums2[j - 1] > nums1[i])
            {
                low = i + 1;

                continue;
            }

            if (i > 0 && nums1[i - 1] > nums2[j])
            {
                high = i - 1;

                continue;
            }

            result = GetMedian(nums1, nums2, i, j);

            break;
        }

        return result;
    }

    private static double GetMedian(int[] nums1, int[] nums2, int i, int j)
    {
        var maxLeft = GetMaxLeft(nums1, nums2, i, j);

        if ((nums1.Length + nums2.Length) % 2 == 1)
        {
            return maxLeft;
        }

        var minRight = GetMinRight(nums1, nums2, i, j);

        return (maxLeft + minRight) / 2.0;
    }

    private static int GetMaxLeft(int[] nums1, int[] nums2, int i, int j)
    {
        if (i == 0)
        {
            return nums2[j - 1];
        }

        if (j == 0)
        {
            return nums1[i - 1];
        }

        return Math.Max(nums1[i - 1], nums2[j - 1]);
    }

    private static int GetMinRight(int[] nums1, int[] nums2, int i, int j)
    {
        if (i == nums1.Length)
        {
            return nums2[j];
        }

        if (j == nums2.Length)
        {
            return nums1[i];
        }

        return Math.Min(nums1[i], nums2[j]);
    }
}