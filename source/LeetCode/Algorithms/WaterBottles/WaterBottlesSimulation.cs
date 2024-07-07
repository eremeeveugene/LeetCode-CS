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

namespace LeetCode.Algorithms.WaterBottles;

/// <inheritdoc />
public class WaterBottlesSimulation : IWaterBottles
{
    /// <summary>
    ///     Time complexity - O(log(m)N), where N is the number of initial full bottles and M is equal to numExchange
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="numBottles"></param>
    /// <param name="numExchange"></param>
    /// <returns></returns>
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        var result = numBottles;

        while (numBottles >= numExchange)
        {
            var bottles = numBottles / numExchange;

            result += bottles;

            numBottles = numBottles - (bottles * numExchange) + bottles;
        }

        return result;
    }
}