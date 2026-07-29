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

namespace LeetCode.Algorithms.KthLargestElementInAnArray;

/// <inheritdoc />
public sealed class KthLargestElementInAnArrayCountingSort : IKthLargestElementInAnArray
{
    private const int MinNum = -10000;
    private const int MaxNum = 10000;
    private const int NumOffset = -MinNum;
    private const int NumsFrequenciesLength = MaxNum - MinNum + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindKthLargest(int[] nums, int k)
    {
        Span<int> numsFrequencies = stackalloc int[NumsFrequenciesLength];

        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            numsFrequencies[num + NumOffset]++;
        }

        var index = NumsFrequenciesLength - 1;

        k -= numsFrequencies[index];

        while (k > 0)
        {
            index--;

            k -= numsFrequencies[index];
        }

        return index - NumOffset;
    }
}