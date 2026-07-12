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

namespace LeetCode.Algorithms.RandomPickIndex;

/// <inheritdoc />
public sealed class RandomPickIndexReservoirSampling : IRandomPickIndex
{
    private static readonly Random Random = new();
    private readonly int[] _nums;

    /// <summary>
    ///     Initializes a new instance of the <see cref="RandomPickIndexReservoirSampling" /> class.
    /// </summary>
    /// <param name="nums">The array of integers to pick indices from.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public RandomPickIndexReservoirSampling(int[] nums)
    {
        _nums = nums;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Pick(int target)
    {
        var result = -1;

        var count = 0;

        for (var i = 0; i < _nums.Length; i++)
        {
            if (_nums[i] != target)
            {
                continue;
            }

            count++;

            if (Random.Next(count) == 0)
            {
                result = i;
            }
        }

        return result;
    }
}