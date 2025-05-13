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

namespace LeetCode.Algorithms.ShortestSubarrayWithSumAtLeastK;

/// <inheritdoc />
public class ShortestSubarrayWithSumAtLeastKLinkedList : IShortestSubarrayWithSumAtLeastK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int ShortestSubarray(int[] nums, int k)
    {
        var prefixSum = new long[nums.Length + 1];

        for (var i = 0; i < nums.Length; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }

        var linkedList = new LinkedList<int>();

        var minLength = nums.Length + 1;

        for (var i = 0; i <= nums.Length; i++)
        {
            while (linkedList is { Count: > 0, First: not null } &&
                   prefixSum[i] - prefixSum[linkedList.First.Value] >= k)
            {
                minLength = Math.Min(minLength, i - linkedList.First.Value);

                linkedList.RemoveFirst();
            }

            while (linkedList is { Count: > 0, Last: not null } && prefixSum[i] <= prefixSum[linkedList.Last.Value])
            {
                linkedList.RemoveLast();
            }

            linkedList.AddLast(i);
        }

        return minLength <= nums.Length ? minLength : -1;
    }
}