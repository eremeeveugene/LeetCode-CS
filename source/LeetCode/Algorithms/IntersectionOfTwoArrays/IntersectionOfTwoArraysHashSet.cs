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

namespace LeetCode.Algorithms.IntersectionOfTwoArrays;

/// <inheritdoc />
public sealed class IntersectionOfTwoArraysHashSet : IIntersectionOfTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n1 + n2)
    ///     Space complexity - O(n1 + m), where m is the number of common elements between nums1 and nums2
    /// </remarks>
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var nums1HashSet = new HashSet<int>(nums1);
        var intersectionHashSet = new HashSet<int>();

        for (var i = 0; i < nums2.Length; i++)
        {
            var num2 = nums2[i];

            if (nums1HashSet.Contains(num2))
            {
                intersectionHashSet.Add(num2);
            }
        }

        return [.. intersectionHashSet];
    }
}