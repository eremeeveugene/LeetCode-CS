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
public class MedianOfTwoSortedArraysIterative : IMedianOfTwoSortedArrays
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var concat = new int[nums1.Length + nums2.Length];

        var nums1Index = 0;
        var nums2Index = 0;

        while (nums1Index < nums1.Length || nums2Index < nums2.Length)
        {
            int? num1 = null;

            if (nums1Index < nums1.Length)
            {
                num1 = nums1[nums1Index];
            }

            int? num2 = null;

            if (nums2Index < nums2.Length)
            {
                num2 = nums2[nums2Index];
            }

            if (num1.HasValue && num2.HasValue)
            {
                if (num1 < num2)
                {
                    concat[nums1Index + nums2Index] = num1.Value;

                    nums1Index++;
                }
                else
                {
                    concat[nums1Index + nums2Index] = num2.Value;

                    nums2Index++;
                }
            }
            else if (num1.HasValue)
            {
                concat[nums1Index + nums2Index] = num1.Value;

                nums1Index++;
            }
            else if (num2.HasValue)
            {
                concat[nums1Index + nums2Index] = num2.Value;

                nums2Index++;
            }
        }

        var index = concat.Length / 2;

        if (concat.Length % 2 == 0)
        {
            return (concat[index - 1] + concat[index]) / 2.0;
        }

        return concat[index];
    }
}