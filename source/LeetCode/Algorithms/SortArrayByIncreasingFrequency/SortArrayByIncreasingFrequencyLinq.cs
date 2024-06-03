// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.SortArrayByIncreasingFrequency;

/// <inheritdoc />
public class SortArrayByIncreasingFrequencyLinq : ISortArrayByIncreasingFrequency
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] FrequencySort(int[] nums)
    {
        return nums.GroupBy(v => v)
            .OrderBy(g => g.Count())
            .ThenByDescending(g => g.Key)
            .SelectMany(g => g)
            .ToArray();
    }
}