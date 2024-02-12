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

using System.Numerics;

namespace LeetCode.Algorithms.NumberOfStepsToReduceNumberToZero;

/// <inheritdoc />
public class NumberOfStepsToReduceNumberToZeroBitwise : INumberOfStepsToReduceNumberToZero
{
    /// <summary>
    ///     Time complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int NumberOfSteps(int num)
    {
        return BitOperations.Log2((uint)num) + BitOperations.PopCount((uint)num);
    }
}