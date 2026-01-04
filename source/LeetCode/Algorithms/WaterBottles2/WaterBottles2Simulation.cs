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

/// <inheritdoc />
public class WaterBottles2Simulation : IWaterBottles2
{
    /// <summary>
    ///     Time complexity - O(n), where n is the number of initial bottles
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="numBottles"></param>
    /// <param name="numExchange"></param>
    /// <returns></returns>
    public int MaxBottlesDrunk(int numBottles, int numExchange)
    {
        var drunkBottles = 0;

        var emptyBottles = 0;

        while (numBottles > 0)
        {
            drunkBottles += numBottles;
            emptyBottles += numBottles;

            numBottles = 0;

            while (emptyBottles >= numExchange)
            {
                emptyBottles -= numExchange;

                numBottles++;
                numExchange++;
            }
        }

        return drunkBottles;
    }
}