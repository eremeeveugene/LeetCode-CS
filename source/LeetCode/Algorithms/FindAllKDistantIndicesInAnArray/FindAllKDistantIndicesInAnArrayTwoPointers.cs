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

namespace LeetCode.Algorithms.FindAllKDistantIndicesInAnArray;

/// <inheritdoc />
public sealed class FindAllKDistantIndicesInAnArrayTwoPointers : IFindAllKDistantIndicesInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var result = new List<int>();

        var right = 0;

        for (var j = 0; j < nums.Length; j++)
        {
            if (nums[j] != key)
            {
                continue;
            }

            var left = Math.Max(right, j - k);

            right = Math.Min(nums.Length - 1, j + k) + 1;

            for (var i = left; i < right; i++)
            {
                result.Add(i);
            }
        }

        return result;
    }
}