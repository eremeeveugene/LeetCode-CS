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
public sealed class RandomPickIndexDictionary : IRandomPickIndex
{
    private static readonly Random Random = new();
    private readonly Dictionary<int, List<int>> _numToIndicesDictionary = [];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    public RandomPickIndexDictionary(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!_numToIndicesDictionary.TryGetValue(num, out var indices))
            {
                indices = [];

                _numToIndicesDictionary[num] = indices;
            }

            indices.Add(i);
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Pick(int target)
    {
        var indices = _numToIndicesDictionary[target];
        var index = Random.Next(indices.Count);

        return indices[index];
    }
}