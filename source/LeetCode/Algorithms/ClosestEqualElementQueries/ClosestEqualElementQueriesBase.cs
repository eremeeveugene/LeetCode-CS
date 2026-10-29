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
public abstract class ClosestEqualElementQueriesBase : IClosestEqualElementQueries
{
    /// <inheritdoc />
    public abstract IList<int> SolveQueries(int[] nums, int[] queries);

    /// <summary>
    ///     Computes the shortest distance between two indices on a circular array
    ///     of length <paramref name="n" />, i.e. <c>min(|a - b|, n - |a - b|)</c>.
    /// </summary>
    /// <param name="a">The first index.</param>
    /// <param name="b">The second index.</param>
    /// <param name="n">The length of the circular array.</param>
    /// <returns>The shorter of the two arc distances between <paramref name="a" /> and <paramref name="b" />.</returns>
    protected static int GetCircularDistance(int a, int b, int n)
    {
        var directDistance = Math.Abs(a - b);

        return Math.Min(directDistance, n - directDistance);
    }

    /// <summary>
    ///     Groups the indexes of <paramref name="nums" /> by value, each group in ascending order.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The dictionary mapping each distinct value to the ascending list of its indexes.</returns>
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of <paramref name="nums" />.
    ///     Space complexity - O(n), where n is the length of <paramref name="nums" />.
    /// </remarks>
    protected static Dictionary<int, List<int>> GetNumToIndexesDictionary(int[] nums)
    {
        var numToIndexesDictionary = new Dictionary<int, List<int>>();

        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (!numToIndexesDictionary.TryGetValue(num, out var indexes))
            {
                indexes = [];

                numToIndexesDictionary[num] = indexes;
            }

            indexes.Add(i);
        }

        return numToIndexesDictionary;
    }
}