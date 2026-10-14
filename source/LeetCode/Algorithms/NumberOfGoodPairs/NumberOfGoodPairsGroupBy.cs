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
        var numToGroupDictionary = new Dictionary<int, List<int>>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!numToGroupDictionary.TryGetValue(num, out var group))
            {
                group = [];

                numToGroupDictionary.Add(num, group);
            }

            group.Add(num);
        }

        var groups = new List<int>[numToGroupDictionary.Count];

        numToGroupDictionary.Values.CopyTo(groups, 0);

        var result = 0;

        for (var i = 0; i < groups.Length; i++)
        {
            var group = groups[i];

            result += GetPairsCount(group.Count);
        }

        return result;
    }

    private static int GetPairsCount(int count)
    {
        return count * (count - 1) / 2;
    }
}