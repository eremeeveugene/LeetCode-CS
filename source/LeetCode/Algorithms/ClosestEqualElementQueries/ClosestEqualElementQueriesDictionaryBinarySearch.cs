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

namespace LeetCode.Algorithms.ClosestEqualElementQueries;

/// <inheritdoc />
public sealed class ClosestEqualElementQueriesDictionaryBinarySearch : ClosestEqualElementQueriesBase
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + q log n), where n is the length of <paramref name="nums" />
    ///     and q is the length of <paramref name="queries" />.
    ///     Space complexity - O(n + q), where n is the length of <paramref name="nums" />
    ///     and q is the length of <paramref name="queries" />.
    /// </remarks>
    public override IList<int> SolveQueries(int[] nums, int[] queries)
    {
        var numToIndexesDictionary = new Dictionary<int, List<int>>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!numToIndexesDictionary.TryGetValue(num, out var indexes))
            {
                indexes = [];

                numToIndexesDictionary[num] = indexes;
            }

            indexes.Add(i);
        }

        var n = nums.Length;

        for (var i = 0; i < queries.Length; i++)
        {
            var queryIndex = queries[i];
            var num = nums[queryIndex];
            var indexes = numToIndexesDictionary[num];

            if (indexes.Count == 1)
            {
                queries[i] = -1;

                continue;
            }

            var position = indexes.BinarySearch(queryIndex);

            var previousIndex = position == 0
                ? indexes[^1]
                : indexes[position - 1];

            var nextIndex = position == indexes.Count - 1
                ? indexes[0]
                : indexes[position + 1];

            var previousDistance = GetCircularDistance(queryIndex, previousIndex, n);
            var nextDistance = GetCircularDistance(queryIndex, nextIndex, n);

            queries[i] = Math.Min(previousDistance, nextDistance);
        }

        return queries;
    }
}