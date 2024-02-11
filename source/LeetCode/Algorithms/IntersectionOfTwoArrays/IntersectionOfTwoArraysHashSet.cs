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

namespace LeetCode.Algorithms.IntersectionOfTwoArrays;

/// <inheritdoc />
public class IntersectionOfTwoArraysHashSet : IIntersectionOfTwoArrays
{
    /// <summary>
    ///     Time complexity - O(n + m)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var nums1HashSet = new HashSet<int>(nums1);
        var intersectionHashSet = new HashSet<int>();

        foreach (var num in nums2)
        {
            if (nums1HashSet.Contains(num))
            {
                intersectionHashSet.Add(num);
            }
        }

        return [.. intersectionHashSet];
    }
}