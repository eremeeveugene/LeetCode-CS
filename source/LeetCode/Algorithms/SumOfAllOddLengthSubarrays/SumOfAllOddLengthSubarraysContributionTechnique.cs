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

namespace LeetCode.Algorithms.SumOfAllOddLengthSubarrays;

/// <inheritdoc />
public sealed class SumOfAllOddLengthSubarraysContributionTechnique : ISumOfAllOddLengthSubarrays
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int SumOddLengthSubarrays(int[] arr)
    {
        var sum = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            var left = i + 1;
            var right = arr.Length - i;
            var totalSubarrays = left * right;
            var oddCount = (totalSubarrays + 1) / 2;

            sum += arr[i] * oddCount;
        }

        return sum;
    }
}