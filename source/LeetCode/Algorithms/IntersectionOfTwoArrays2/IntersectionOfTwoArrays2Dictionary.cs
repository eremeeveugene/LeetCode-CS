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

namespace LeetCode.Algorithms.IntersectionOfTwoArrays2;

/// <inheritdoc />
public sealed class IntersectionOfTwoArrays2Dictionary : IIntersectionOfTwoArrays2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var nums1Dictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums1.Length; i++)
        {
            var num1 = nums1[i];

            if (!nums1Dictionary.TryAdd(num1, 1))
            {
                nums1Dictionary[num1]++;
            }
        }

        var result = new List<int>();

        foreach (var num2 in nums2)
        {
            if (!nums1Dictionary.ContainsKey(num2))
            {
                continue;
            }

            result.Add(num2);

            nums1Dictionary[num2]--;

            if (nums1Dictionary[num2] == 0)
            {
                nums1Dictionary.Remove(num2);
            }
        }

        return [.. result];
    }
}