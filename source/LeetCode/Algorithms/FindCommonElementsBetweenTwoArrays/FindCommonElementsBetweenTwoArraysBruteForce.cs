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
public sealed class FindCommonElementsBetweenTwoArraysBruteForce : IFindCommonElementsBetweenTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        var answer1 = CountCommonElements(nums1, nums2);
        var answer2 = CountCommonElements(nums2, nums1);

        return [answer1, answer2];
    }

    private static int CountCommonElements(int[] source, int[] target)
    {
        var count = 0;

        for (var i = 0; i < source.Length; i++)
        {
            var num = source[i];

            for (var j = 0; j < target.Length; j++)
            {
                if (target[j] != num)
                {
                    continue;
                }

                count++;

                break;
            }
        }

        return count;
    }
}