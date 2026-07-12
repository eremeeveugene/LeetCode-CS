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
public sealed class IntersectionOfTwoArraysHashSetIntersectWith : IIntersectionOfTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n1 + n2 + min(n1, n2) + m)
    ///     Space complexity - O(n1 + n2 + min(n1, n2))
    /// </remarks>
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var nums1HashSet = new HashSet<int>(nums1);
        var nums2HashSet = new HashSet<int>(nums2);

        nums1HashSet.IntersectWith(nums2HashSet);

        return [.. nums1HashSet];
    }
}