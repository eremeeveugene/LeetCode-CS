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
public sealed class WaterBottles2Math : IWaterBottles2
{
    private const int QuadraticA = 1;
    private const int LinearMultiplier = 2;
    private const int LinearOffset = 3;
    private const int ConstantMultiplier = -2;
    private const double Two = 2.0;
    private const double Four = 4.0;

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="numBottles"></param>
    /// <param name="numExchange"></param>
    /// <returns></returns>
    public int MaxBottlesDrunk(int numBottles, int numExchange)
    {
        var quadraticB = (LinearMultiplier * numExchange) - LinearOffset;
        var quadraticC = ConstantMultiplier * numBottles;

        var discriminant = ((double)quadraticB * quadraticB) - (Four * QuadraticA * quadraticC);

        var root = (-quadraticB + Math.Sqrt(discriminant)) / (Two * QuadraticA);

        var maxExchanges = (int)Math.Ceiling(root);

        return numBottles + maxExchanges - 1;
    }
}