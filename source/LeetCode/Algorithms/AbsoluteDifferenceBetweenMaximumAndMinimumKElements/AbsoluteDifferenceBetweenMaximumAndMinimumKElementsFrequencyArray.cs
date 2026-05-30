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

namespace LeetCode.Algorithms.AbsoluteDifferenceBetweenMaximumAndMinimumKElements;

/// <inheritdoc />
public sealed class AbsoluteDifferenceBetweenMaximumAndMinimumKElementsFrequencyArray : IAbsoluteDifferenceBetweenMaximumAndMinimumKElements
{
    public int AbsDifference(int[] nums, int k)
    {
        var maxNum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxNum)
            {
                maxNum = nums[i];
            }
        }

        Span<int> numFrequencies = stackalloc int[maxNum];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            numFrequencies[num - 1]++;
        }

        var result = 0;

        var remainingCount = k;

        for (var i = 0; i < numFrequencies.Length; i++)
        {
            var count = Math.Min(numFrequencies[i], remainingCount);

            result += (i + 1) * count;

            remainingCount -= count;

            if (remainingCount == 0)
            {
                break;
            }
        }

        remainingCount = k;

        for (var i = numFrequencies.Length - 1; i >= 0; i--)
        {
            var count = Math.Min(numFrequencies[i], remainingCount);

            result -= (i + 1) * count;

            remainingCount -= count;

            if (remainingCount == 0)
            {
                break;
            }
        }

        return Math.Abs(result);
    }
}