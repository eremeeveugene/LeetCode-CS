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

namespace LeetCode.Algorithms.FirstUniqueEvenElement;

/// <inheritdoc />
public sealed class FirstUniqueEvenElementFrequencyArray : IFirstUniqueEvenElement
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FirstUniqueEven(int[] nums)
    {
        Span<int> frequencies = stackalloc int[101];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num % 2 != 0)
            {
                continue;
            }

            frequencies[num]++;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num % 2 != 0)
            {
                continue;
            }

            if (frequencies[num] == 1)
            {
                return num;
            }
        }

        return -1;
    }
}