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

namespace LeetCode.Algorithms.DistributeElementsIntoTwoArrays1;

/// <inheritdoc />
public sealed class DistributeElementsIntoTwoArrays1SimulationBuffer : IDistributeElementsIntoTwoArrays1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] ResultArray(int[] nums)
    {
        var n = nums.Length;

        Span<int> buffer = stackalloc int[n];

        buffer[0] = nums[0];
        buffer[1] = -nums[1];

        var firstArrayCount = 1;
        var firstArrayLast = nums[0];
        var secondArrayLast = nums[1];

        for (var i = 2; i < n; i++)
        {
            var num = nums[i];

            if (firstArrayLast > secondArrayLast)
            {
                buffer[i] = num;

                firstArrayCount++;
                firstArrayLast = num;
            }
            else
            {
                buffer[i] = -num;

                secondArrayLast = num;
            }
        }

        var firstArrayIndex = 0;
        var secondArrayIndex = firstArrayCount;

        for (var i = 0; i < n; i++)
        {
            var num = buffer[i];

            if (num > 0)
            {
                nums[firstArrayIndex] = num;

                firstArrayIndex++;
            }
            else
            {
                nums[secondArrayIndex] = -num;

                secondArrayIndex++;
            }
        }

        return nums;
    }
}