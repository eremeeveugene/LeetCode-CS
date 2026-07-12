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

namespace LeetCode.Algorithms.NumberOfGoodPairs;

/// <inheritdoc />
public sealed class NumberOfGoodPairsGroupBy : INumberOfGoodPairs
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int NumIdenticalPairs(int[] nums)
    {
        var groups = nums.GroupBy(n => n);

        return groups.Sum(group => GetPairsCount(group.Count()));
    }

    private static int GetPairsCount(int count)
    {
        return count * (count - 1) / 2;
    }
}