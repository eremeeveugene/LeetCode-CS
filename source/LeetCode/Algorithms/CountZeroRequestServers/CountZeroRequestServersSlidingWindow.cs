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

namespace LeetCode.Algorithms.CountZeroRequestServers;

/// <inheritdoc />
public sealed class CountZeroRequestServersSlidingWindow : ICountZeroRequestServers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m log m + q log q), where m is the length of logs and q is the length of queries
    ///     Space complexity - O(n + q + log m)
    /// </remarks>
    public int[] CountServers(int n, int[][] logs, int x, int[] queries)
    {
        var m = logs.Length;
        var q = queries.Length;

        Array.Sort(logs, (a, b) => a[1].CompareTo(b[1]));

        Span<int> queryIndices = stackalloc int[q];

        for (var i = 0; i < q; i++)
        {
            queryIndices[i] = i;
        }

        queryIndices.Sort((a, b) => queries[a].CompareTo(queries[b]));

        Span<int> serverRequestCounts = stackalloc int[n + 1];

        var activeServersCount = 0;

        var leftIndex = 0;
        var rightIndex = 0;

        for (var i = 0; i < q; i++)
        {
            var queryIndex = queryIndices[i];
            var query = queries[queryIndex];

            var windowStart = query - x;

            while (rightIndex < m && logs[rightIndex][1] <= query)
            {
                var log = logs[rightIndex];

                var serverId = log[0];

                if (serverRequestCounts[serverId] == 0)
                {
                    activeServersCount++;
                }

                serverRequestCounts[serverId]++;

                rightIndex++;
            }

            while (leftIndex < rightIndex && logs[leftIndex][1] < windowStart)
            {
                var log = logs[leftIndex];

                var serverId = log[0];

                serverRequestCounts[serverId]--;

                if (serverRequestCounts[serverId] == 0)
                {
                    activeServersCount--;
                }

                leftIndex++;
            }

            queries[queryIndex] = n - activeServersCount;
        }

        return queries;
    }
}