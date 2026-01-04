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

namespace LeetCode.Algorithms.NumberOfZeroFilledSubarrays;

/// <inheritdoc />
public class NumberOfZeroFilledSubarraysCounting : INumberOfZeroFilledSubarrays
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public long ZeroFilledSubarray(int[] nums)
    {
        long count = 0;
        var zeros = 0;

        foreach (var num in nums)
        {
            if (num == 0)
            {
                zeros++;

                count += zeros;
            }
            else
            {
                zeros = 0;
            }
        }

        return count;
    }
}