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
public class MinimumCommonValueHashSet : IMinimumCommonValue
{
    /// <summary>
    ///     Time complexity - O(n + m), where n is the length of nums2 and m is the length of nums1
    ///     Space complexity - O(n), where n is the length of nums2
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int GetCommon(int[] nums1, int[] nums2)
    {
        var nums2HashSet = new HashSet<int>(nums2);

        foreach (var num1 in nums1)
        {
            if (nums2HashSet.Contains(num1))
            {
                return num1;
            }
        }

        return -1;
    }
}