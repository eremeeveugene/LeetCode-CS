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

namespace LeetCode.Algorithms.FinalArrayStateAfterKMultiplicationOperations;

/// <inheritdoc />
public class FinalArrayStateAfterKMultiplicationOperationsGreedy : IFinalArrayStateAfterKMultiplicationOperations
{
    /// <summary>
    ///     Time complexity - O(n * k)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <param name="multiplier"></param>
    /// <returns></returns>
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        for (var i = 0; i < k; i++)
        {
            var min = int.MaxValue;
            var minIndex = 0;

            for (var j = 0; j < nums.Length; j++)
            {
                if (nums[j] >= min)
                {
                    continue;
                }

                minIndex = j;
                min = nums[j];
            }

            nums[minIndex] *= multiplier;
        }

        return nums;
    }
}