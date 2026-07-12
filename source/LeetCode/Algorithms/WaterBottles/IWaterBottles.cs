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

namespace LeetCode.Algorithms.WaterBottles;

/// <summary>
///     https://leetcode.com/problems/water-bottles/
/// </summary>
public interface IWaterBottles
{
    /// <summary>
    ///     Computes the maximum number of water bottles that can be drunk starting with
    ///     <paramref name="numBottles" /> full bottles, where every <paramref name="numExchange" /> empty bottles
    ///     can be exchanged for one full bottle.
    /// </summary>
    /// <param name="numBottles">The initial number of full water bottles.</param>
    /// <param name="numExchange">The number of empty bottles required to exchange for one full bottle.</param>
    /// <returns>The maximum number of water bottles that can be drunk.</returns>
    int NumWaterBottles(int numBottles, int numExchange);
}