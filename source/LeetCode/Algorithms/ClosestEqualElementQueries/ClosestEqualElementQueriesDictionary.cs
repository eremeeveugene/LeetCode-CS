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
public sealed class ClosestEqualElementQueriesDictionary : IClosestEqualElementQueries
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + q log n), where n is the length of <paramref name="nums" />
    ///     and q is the length of <paramref name="queries" />.
    ///     Space complexity - O(n + q), where n is the length of <paramref name="nums" />
    ///     and q is the length of <paramref name="queries" />.
    /// </remarks>
    public IList<int> SolveQueries(int[] nums, int[] queries)
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

        var result = new int[queries.Length];
        var n = nums.Length;

        for (var i = 0; i < queries.Length; i++)
        {
            var queryIndex = queries[i];
            var num = nums[queryIndex];
            var indexes = numToIndexesDictionary[num];

            if (indexes.Count == 1)
            {
                result[i] = -1;

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

            result[i] = Math.Min(previousDistance, nextDistance);
        }

        return result;
    }

    /// <summary>
    ///     Computes the shortest distance between two indices on a circular array
    ///     of length <paramref name="n" />, i.e. <c>min(|a - b|, n - |a - b|)</c>.
    /// </summary>
    /// <param name="a">The first index.</param>
    /// <param name="b">The second index.</param>
    /// <param name="n">The length of the circular array.</param>
    /// <returns>The shorter of the two arc distances between <paramref name="a" /> and <paramref name="b" />.</returns>
    private static int GetCircularDistance(int a, int b, int n)
    {
        var directDistance = Math.Abs(a - b);

        return Math.Min(directDistance, n - directDistance);
    }
}