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

namespace LeetCode.Algorithms.FindingPairsWithCertainSum;

/// <inheritdoc />
public sealed class FindingPairsWithCertainSumDictionary : IFindingPairsWithCertainSum
{
    private readonly int[] _nums1;
    private readonly int[] _nums2;
    private readonly Dictionary<int, int> _nums2FrequencyDictionary;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    public FindingPairsWithCertainSumDictionary(int[] nums1, int[] nums2)
    {
        _nums1 = nums1;
        _nums2 = nums2;
        _nums2FrequencyDictionary = new Dictionary<int, int>();

        foreach (var num2 in nums2)
        {
            if (!_nums2FrequencyDictionary.TryAdd(num2, 1))
            {
                _nums2FrequencyDictionary[num2]++;
            }
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Add(int index, int val)
    {
        _nums2FrequencyDictionary[_nums2[index]]--;

        if (_nums2FrequencyDictionary[_nums2[index]] == 0)
        {
            _nums2FrequencyDictionary.Remove(_nums2[index]);
        }

        _nums2[index] += val;

        if (!_nums2FrequencyDictionary.TryAdd(_nums2[index], 1))
        {
            _nums2FrequencyDictionary[_nums2[index]]++;
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Count(int tot)
    {
        var count = 0;

        foreach (var num1 in _nums1)
        {
            if (_nums2FrequencyDictionary.TryGetValue(tot - num1, out var value))
            {
                count += value;
            }
        }

        return count;
    }
}