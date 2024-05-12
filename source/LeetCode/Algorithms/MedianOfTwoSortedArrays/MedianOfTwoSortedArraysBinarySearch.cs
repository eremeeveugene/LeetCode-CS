// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MedianOfTwoSortedArraysBinarySearch : IMedianOfTwoSortedArrays
{
    /// <summary>
    ///     Time complexity - O(log min(n,m))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        while (true)
        {
            if (nums1.Length > nums2.Length)
            {
                (nums1, nums2) = (nums2, nums1);

                continue;
            }

            var low = 0;
            var high = nums1.Length;
            var halfLen = (nums1.Length + nums2.Length + 1) / 2;

            while (low <= high)
            {
                var i = (low + high) / 2;
                var j = halfLen - i;

                if (i < nums1.Length && nums2[j - 1] > nums1[i])
                {
                    low = i + 1;
                }
                else if (i > 0 && nums1[i - 1] > nums2[j])
                {
                    high = i - 1;
                }
                else
                {
                    int maxLeft;

                    if (i == 0)
                    {
                        maxLeft = nums2[j - 1];
                    }
                    else if (j == 0)
                    {
                        maxLeft = nums1[i - 1];
                    }
                    else
                    {
                        maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]);
                    }

                    if ((nums1.Length + nums2.Length) % 2 == 1)
                    {
                        return maxLeft;
                    }

                    int minRight;

                    if (i == nums1.Length)
                    {
                        minRight = nums2[j];
                    }
                    else if (j == nums2.Length)
                    {
                        minRight = nums1[i];
                    }
                    else
                    {
                        minRight = Math.Min(nums1[i], nums2[j]);
                    }

                    return (maxLeft + minRight) / 2.0;
                }
            }

            return 0;
        }
    }
}