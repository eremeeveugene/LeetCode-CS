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

namespace LeetCode.Algorithms.MinimumOperationsToMakeArraySumDivisibleByK;

/// <inheritdoc />
public sealed class MinimumOperationsToMakeArraySumDivisibleByKGreedy : IMinimumOperationsToMakeArraySumDivisibleByK
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinOperations(int[] nums, int k)
    {
        var sum = 0;

        foreach (var i in nums)
        {
            sum += i;
        }

        return sum % k;
    }
}