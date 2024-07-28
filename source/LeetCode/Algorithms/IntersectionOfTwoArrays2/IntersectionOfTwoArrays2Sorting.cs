﻿namespace LeetCode.Algorithms.IntersectionOfTwoArrays2;

/// <inheritdoc />
public class IntersectionOfTwoArrays2Sorting : IIntersectionOfTwoArrays2
{
    /// <summary>
    ///     Time complexity - O(n log n + m log m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);

        var result = new List<int>();

        var i = 0;
        var j = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                i++;
            }
            else if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                result.Add(nums1[i]);

                i++;
                j++;
            }
        }

        return [.. result];
    }
}