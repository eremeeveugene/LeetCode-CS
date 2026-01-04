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

using System.Numerics;

namespace LeetCode.Algorithms.MinimumOperationsToMakeTheIntegerZero;

/// <inheritdoc />
public class MinimumOperationsToMakeTheIntegerZeroBitwise : IMinimumOperationsToMakeTheIntegerZero
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int MakeTheIntegerZero(int num1, int num2)
    {
        for (var k = 1; k <= 60; k++)
        {
            var x = num1 - ((long)k * num2);

            if (x < 0)
            {
                break;
            }

            var numberOfSetBits = BitOperations.PopCount((ulong)x);

            if (numberOfSetBits <= k && k <= x)
            {
                return k;
            }
        }

        return -1;
    }
}