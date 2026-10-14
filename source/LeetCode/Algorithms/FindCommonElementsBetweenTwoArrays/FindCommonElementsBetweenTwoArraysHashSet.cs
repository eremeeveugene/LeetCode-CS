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

namespace LeetCode.Algorithms.FindCommonElementsBetweenTwoArrays;

/// <inheritdoc />
public sealed class FindCommonElementsBetweenTwoArraysHashSet : IFindCommonElementsBetweenTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </remarks>
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        var nums1HashSet = new HashSet<int>(nums1);
        var nums2HashSet = new HashSet<int>(nums2);

        var answer1 = CountCommonElements(nums1, nums2HashSet);
        var answer2 = CountCommonElements(nums2, nums1HashSet);

        return [answer1, answer2];
    }

    private static int CountCommonElements(int[] source, HashSet<int> targetHashSet)
    {
        var count = 0;

        for (var i = 0; i < source.Length; i++)
        {
            var num = source[i];

            if (targetHashSet.Contains(num))
            {
                count++;
            }
        }

        return count;
    }
}