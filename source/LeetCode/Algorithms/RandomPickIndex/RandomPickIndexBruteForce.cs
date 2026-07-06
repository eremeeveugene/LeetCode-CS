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
public sealed class RandomPickIndexBruteForce : IRandomPickIndex
{
    private static readonly Random Random = new();
    private readonly int[] _nums;

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    public RandomPickIndexBruteForce(int[] nums)
    {
        _nums = nums;
    }

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    public int Pick(int target)
    {
        var indices = new List<int>();

        for (var i = 0; i < _nums.Length; i++)
        {
            if (_nums[i] == target)
            {
                indices.Add(i);
            }
        }

        var index = Random.Next(indices.Count);

        return indices[index];
    }
}