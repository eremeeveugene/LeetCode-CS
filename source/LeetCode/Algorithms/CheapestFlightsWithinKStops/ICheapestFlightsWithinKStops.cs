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

/// <summary>
///     https://leetcode.com/problems/cheapest-flights-within-k-stops/
/// </summary>
public interface ICheapestFlightsWithinKStops
{
    int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k);
}