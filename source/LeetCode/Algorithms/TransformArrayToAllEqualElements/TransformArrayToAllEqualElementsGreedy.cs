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

        var previous1 = nums[0] == 1 ? 0 : 1;
        var previous2 = nums[0] == -1 ? 0 : 1;

        var count1 = previous1;
        var count2 = previous2;

        for (var i = 1; i < nums.Length - 1; i++)
        {
            var num = nums[i];

            var b1 = num == 1 ? 0 : 1;
            var current1 = b1 ^ previous1;

            previous1 = current1;
            count1 += current1;

            var b2 = num == -1 ? 0 : 1;
            var current2 = b2 ^ previous2;

            previous2 = current2;
            count2 += current2;

            if (count1 > k && count2 > k)
            {
                return false;
            }
        }

        var lastB1 = nums[^1] == 1 ? 0 : 1;
        var ok1 = (lastB1 ^ previous1) == 0 && count1 <= k;

        var lastB2 = nums[^1] == -1 ? 0 : 1;
        var ok2 = (lastB2 ^ previous2) == 0 && count2 <= k;

        return ok1 || ok2;
    }
}