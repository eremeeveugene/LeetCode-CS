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

namespace LeetCode.Algorithms.CheapestFlightsWithinKStops;

/// <inheritdoc />
public class CheapestFlightsWithinKStopsBellmanFord : ICheapestFlightsWithinKStops
{
    /// <summary>
    ///     Time complexity - O (k * E)
    ///     Space complexity - O (n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="flights"></param>
    /// <param name="src"></param>
    /// <param name="dst"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        var cost = new int[n];

        Array.Fill(cost, int.MaxValue);

        cost[src] = 0;

        var temp = new int[n];

        Array.Copy(cost, temp, n);

        for (var i = 0; i <= k; i++)
        {
            Array.Copy(cost, temp, n);

            foreach (var flight in flights)
            {
                int u = flight[0], v = flight[1], w = flight[2];

                if (cost[u] == int.MaxValue)
                {
                    continue;
                }

                if (cost[u] + w < temp[v])
                {
                    temp[v] = cost[u] + w;
                }
            }

            Array.Copy(temp, cost, n);
        }

        return cost[dst] == int.MaxValue ? -1 : cost[dst];
    }
}