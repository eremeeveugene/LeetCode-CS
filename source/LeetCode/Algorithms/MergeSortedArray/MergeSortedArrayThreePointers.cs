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

namespace LeetCode.Algorithms.MergeSortedArray;

/// <summary>
///     https://leetcode.com/problems/merge-sorted-array/description/
/// </summary>
public class MergeSortedArrayThreePointers
{
    /// <summary>
    ///     Time complexity - O(m+n)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="m"></param>
    /// <param name="nums2"></param>
    /// <param name="n"></param>
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var nums1Index = m - 1;
        var nums2Index = n - 1;
        var k = m + n - 1;

        while (nums1Index >= 0 && nums2Index >= 0)
        {
            if (nums1[nums1Index] > nums2[nums2Index])
            {
                nums1[k] = nums1[nums1Index];
                nums1Index--;
            }
            else
            {
                nums1[k] = nums2[nums2Index];
                nums2Index--;
            }

            k--;
        }

        while (nums2Index >= 0)
        {
            nums1[k] = nums2[nums2Index];
            nums2Index--;
            k--;
        }
    }
}