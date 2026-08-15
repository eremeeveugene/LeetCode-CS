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

namespace LeetCode.Algorithms.TransformArrayToAllEqualElements;

/// <inheritdoc />
public sealed class TransformArrayToAllEqualElementsGreedy : ITransformArrayToAllEqualElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanMakeEqual(int[] nums, int k)
    {
        if (nums.Length <= 1)
        {
            return true;
        }

        return CanMakeEqualTo(nums, k, 1) || CanMakeEqualTo(nums, k, -1);
    }

    private static bool CanMakeEqualTo(int[] nums, int k, int target)
    {
        var previous = nums[0] == target ? 0 : 1;

        var count = previous;

        for (var i = 1; i < nums.Length - 1; i++)
        {
            var current = (nums[i] == target ? 0 : 1) ^ previous;

            previous = current;
            count += current;

            if (count > k)
            {
                return false;
            }
        }

        var last = nums[^1] == target ? 0 : 1;

        return (last ^ previous) == 0 && count <= k;
    }
}