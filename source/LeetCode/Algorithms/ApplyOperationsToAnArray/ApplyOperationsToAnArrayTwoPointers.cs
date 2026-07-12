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

namespace LeetCode.Algorithms.ApplyOperationsToAnArray;

/// <inheritdoc />
public sealed class ApplyOperationsToAnArrayTwoPointers : IApplyOperationsToAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] ApplyOperations(int[] nums)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i + 1])
            {
                continue;
            }

            nums[i] *= 2;
            nums[i + 1] = 0;

            i++;
        }

        var index = 0;

        foreach (var num in nums)
        {
            if (num == 0)
            {
                continue;
            }

            nums[index] = num;

            index++;
        }

        while (index < nums.Length)
        {
            nums[index] = 0;

            index++;
        }

        return nums;
    }
}