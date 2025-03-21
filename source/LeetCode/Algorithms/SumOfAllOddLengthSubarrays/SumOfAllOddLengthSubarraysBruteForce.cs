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

namespace LeetCode.Algorithms.SumOfAllOddLengthSubarrays;

/// <inheritdoc />
public class SumOfAllOddLengthSubarraysBruteForce : ISumOfAllOddLengthSubarrays
{
    /// <summary>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int SumOddLengthSubarrays(int[] arr)
    {
        var sum = 0;

        for (var start = 0; start < arr.Length; start++)
        {
            for (var end = start; end < arr.Length; end++)
            {
                var length = end - start + 1;

                if (length % 2 != 1)
                {
                    continue;
                }

                for (var i = start; i <= end; i++)
                {
                    sum += arr[i];
                }
            }
        }

        return sum;
    }
}