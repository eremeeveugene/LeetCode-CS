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

namespace LeetCode.Algorithms.MergeTwo2DArraysBySummingValues;

/// <inheritdoc />
public sealed class MergeTwo2DArraysBySummingValuesTwoPointers : IMergeTwo2DArraysBySummingValues
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        var result = new List<int[]>();

        var nums1Index = 0;
        var nums2Index = 0;

        while (nums1Index < nums1.Length && nums2Index < nums2.Length)
        {
            if (nums1[nums1Index][0] == nums2[nums2Index][0])
            {
                result.Add([nums1[nums1Index][0], nums1[nums1Index][1] + nums2[nums2Index][1]]);

                nums1Index++;
                nums2Index++;
            }
            else if (nums1[nums1Index][0] < nums2[nums2Index][0])
            {
                result.Add(nums1[nums1Index]);

                nums1Index++;
            }
            else
            {
                result.Add(nums2[nums2Index]);

                nums2Index++;
            }
        }

        while (nums1Index < nums1.Length)
        {
            result.Add(nums1[nums1Index++]);
        }

        while (nums2Index < nums2.Length)
        {
            result.Add(nums2[nums2Index++]);
        }

        return result.ToArray();
    }
}