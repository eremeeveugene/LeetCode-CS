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

namespace LeetCode.Algorithms.MinimumCommonValue;

/// <inheritdoc />
public class MinimumCommonValueTwoPointers : IMinimumCommonValue
{
    /// <summary>
    ///     Time complexity - O(n + m), where n is the length of nums2 and m is the length of nums1
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int GetCommon(int[] nums1, int[] nums2)
    {
        var nums1Pointer = 0;
        var nums2Pointer = 0;

        while (nums1Pointer < nums1.Length && nums2Pointer < nums2.Length)
        {
            if (nums1[nums1Pointer] == nums2[nums2Pointer])
            {
                return nums1[nums1Pointer];
            }

            if (nums1[nums1Pointer] < nums2[nums2Pointer])
            {
                nums1Pointer++;
            }
            else
            {
                nums2Pointer++;
            }
        }

        return -1;
    }
}