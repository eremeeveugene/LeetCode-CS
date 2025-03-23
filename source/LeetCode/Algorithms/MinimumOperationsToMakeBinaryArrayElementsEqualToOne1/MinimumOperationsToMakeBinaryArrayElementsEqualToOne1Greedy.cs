// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MinimumOperationsToMakeBinaryArrayElementsEqualToOne1;

/// <inheritdoc />
public class MinimumOperationsToMakeBinaryArrayElementsEqualToOne1Greedy :
    IMinimumOperationsToMakeBinaryArrayElementsEqualToOne1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinOperations(int[] nums)
    {
        var minOperations = 0;

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] == 1)
            {
                continue;
            }

            nums[i] = 1;
            nums[i + 1] ^= 1;
            nums[i + 2] ^= 1;

            minOperations++;
        }

        if (nums[^1] == 0 || nums[^2] == 0)
        {
            return -1;
        }

        return minOperations;
    }
}