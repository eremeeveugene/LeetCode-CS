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

/// <inheritdoc />
public class MergeSortedArrayMergingAndSorting : IMergeSortedArray
{
    /// <summary>
    ///     Time complexity - O((m+n) log(m+n))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="m"></param>
    /// <param name="nums2"></param>
    /// <param name="n"></param>
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0)
        {
            for (var i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }
        }
        else
        {
            for (int i = m, j = 0; i < m + n; i++, j++)
            {
                nums1[i] = nums2[j];
            }

            Array.Sort(nums1);
        }
    }
}