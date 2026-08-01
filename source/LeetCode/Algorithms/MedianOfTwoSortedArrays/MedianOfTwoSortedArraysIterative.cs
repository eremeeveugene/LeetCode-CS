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
public sealed class MedianOfTwoSortedArraysIterative : IMedianOfTwoSortedArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </remarks>
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var concat = new int[nums1.Length + nums2.Length];

        var nums1Index = 0;
        var nums2Index = 0;
        var mergedIndex = 0;

        while (nums1Index < nums1.Length && nums2Index < nums2.Length)
        {
            if (nums1[nums1Index] <= nums2[nums2Index])
            {
                concat[mergedIndex] = nums1[nums1Index];

                nums1Index++;
            }
            else
            {
                concat[mergedIndex] = nums2[nums2Index];

                nums2Index++;
            }

            mergedIndex++;
        }

        while (nums1Index < nums1.Length)
        {
            concat[mergedIndex] = nums1[nums1Index];

            nums1Index++;
            mergedIndex++;
        }

        while (nums2Index < nums2.Length)
        {
            concat[mergedIndex] = nums2[nums2Index];

            nums2Index++;
            mergedIndex++;
        }

        var index = concat.Length / 2;

        if (concat.Length % 2 == 0)
        {
            return (concat[index - 1] + concat[index]) / 2.0;
        }

        return concat[index];
    }
}