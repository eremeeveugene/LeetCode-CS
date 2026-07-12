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

namespace LeetCode.Algorithms.WaterBottles2;

/// <summary>
///     https://leetcode.com/problems/water-bottles-ii/description/
/// </summary>
public interface IWaterBottles2
{
    /// <summary>
    ///     Computes the maximum number of water bottles that can be drunk starting with
    ///     <paramref name="numBottles" /> full bottles, where exchanging <paramref name="numExchange" /> empty
    ///     bottles yields one full bottle and increases the required exchange count by one afterward.
    /// </summary>
    /// <param name="numBottles">The initial number of full water bottles.</param>
    /// <param name="numExchange">The initial number of empty bottles required to exchange for one full bottle.</param>
    /// <returns>The maximum number of water bottles that can be drunk.</returns>
    int MaxBottlesDrunk(int numBottles, int numExchange);
}