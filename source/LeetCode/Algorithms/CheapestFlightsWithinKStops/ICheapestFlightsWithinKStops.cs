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

namespace LeetCode.Algorithms.CheapestFlightsWithinKStops;

/// <summary>
///     https://leetcode.com/problems/cheapest-flights-within-k-stops/
/// </summary>
public interface ICheapestFlightsWithinKStops
{
    /// <summary>
    ///     Finds the cheapest price of a route from <paramref name="src" /> to <paramref name="dst" /> with at most
    ///     <paramref name="k" /> stops.
    /// </summary>
    /// <param name="n">The number of cities.</param>
    /// <param name="flights">The flights, where each flight is a triple of source city, destination city and price.</param>
    /// <param name="src">The departure city.</param>
    /// <param name="dst">The destination city.</param>
    /// <param name="k">The maximum number of stops allowed.</param>
    /// <returns>The cheapest price of such a route, or -1 if no route exists.</returns>
    int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k);
}