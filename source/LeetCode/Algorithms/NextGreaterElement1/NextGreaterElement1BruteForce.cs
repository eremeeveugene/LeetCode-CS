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

namespace LeetCode.Algorithms.NextGreaterElement1;

/// <inheritdoc />
public sealed class NextGreaterElement1BruteForce : INextGreaterElement1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length];

        for (var i = 0; i < nums1.Length; i++)
        {
            var nextIndex = -1;

            for (var j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] != nums2[j])
                {
                    continue;
                }

                nextIndex = j;

                break;
            }

            var next = -1;

            if (nextIndex >= 0)
            {
                for (var j = nextIndex; j < nums2.Length; j++)
                {
                    if (nums2[j] <= nums1[i])
                    {
                        continue;
                    }

                    next = nums2[j];

                    break;
                }
            }

            result[i] = next;
        }

        return result;
    }
}