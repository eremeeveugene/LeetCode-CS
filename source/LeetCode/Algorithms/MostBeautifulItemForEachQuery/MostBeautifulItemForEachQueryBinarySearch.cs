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

namespace LeetCode.Algorithms.MostBeautifulItemForEachQuery;

/// <inheritdoc />
public sealed class MostBeautifulItemForEachQueryBinarySearch : IMostBeautifulItemForEachQuery
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((m + n) log m)
    ///     Space complexity - O(m + n)
    /// </remarks>
    public int[] MaximumBeauty(int[][] items, int[] queries)
    {
        var result = new int[queries.Length];

        Array.Sort(items, (a, b) => a[0].CompareTo(b[0]));

        var maxBeautyUpToPrice = new List<int[]>();
        var maxBeauty = 0;

        foreach (var item in items)
        {
            maxBeauty = Math.Max(maxBeauty, item[1]);
            maxBeautyUpToPrice.Add([item[0], maxBeauty]);
        }

        foreach (var queryWithIndex in queries.Select((query, index) => new[] { query, index }).OrderBy(q => q[0]))
        {
            var query = queryWithIndex[0];
            var originalIndex = queryWithIndex[1];

            var low = 0;
            var high = maxBeautyUpToPrice.Count - 1;
            var beauty = 0;

            while (low <= high)
            {
                var mid = low + ((high - low) / 2);

                if (maxBeautyUpToPrice[mid][0] <= query)
                {
                    beauty = maxBeautyUpToPrice[mid][1];

                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            result[originalIndex] = beauty;
        }

        return result;
    }
}