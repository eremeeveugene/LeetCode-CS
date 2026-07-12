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
public sealed class FinalArrayStateAfterKMultiplicationOperationsPriorityQueue : IFinalArrayStateAfterKMultiplicationOperations
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + k log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        var numsPriorityQueue = new PriorityQueue<(int Value, int Index), (int Value, int Index)>();

        for (var i = 0; i < nums.Length; i++)
        {
            numsPriorityQueue.Enqueue((nums[i], i), (nums[i], i));
        }

        for (var i = 0; i < k; i++)
        {
            var num = numsPriorityQueue.Dequeue();

            num.Value *= multiplier;

            numsPriorityQueue.Enqueue((num.Value, num.Index), (num.Value, num.Index));
        }

        while (numsPriorityQueue.Count > 0)
        {
            var num = numsPriorityQueue.Dequeue();

            nums[num.Index] = num.Value;
        }

        return nums;
    }
}