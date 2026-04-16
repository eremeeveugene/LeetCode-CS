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
public sealed class ClosestEqualElementQueriesDictionaryPreprocessing : ClosestEqualElementQueriesBase
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + q), where n is the length of <paramref name="nums" />
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

        Span<int> minDistances = stackalloc int[n];

        foreach (var indexes in numToIndexesDictionary.Values)
        {
            if (indexes.Count == 1)
            {
                minDistances[indexes[0]] = -1;

                continue;
            }

            for (var i = 0; i < indexes.Count; i++)
            {
                var currentIndex = indexes[i];

                var previousIndex = i == 0
                    ? indexes[^1]
                    : indexes[i - 1];
                var nextIndex = i == indexes.Count - 1
                    ? indexes[0]
                    : indexes[i + 1];

                var previousDistance = GetCircularDistance(currentIndex, previousIndex, n);
                var nextDistance = GetCircularDistance(currentIndex, nextIndex, n);

                minDistances[currentIndex] = Math.Min(previousDistance, nextDistance);
            }
        }

        for (var i = 0; i < queries.Length; i++)
        {
            queries[i] = minDistances[queries[i]];
        }

        return queries;
    }
}