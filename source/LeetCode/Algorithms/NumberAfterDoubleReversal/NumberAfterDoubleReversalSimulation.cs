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

namespace LeetCode.Algorithms.NumberAfterDoubleReversal;

/// <inheritdoc />
public sealed class NumberAfterDoubleReversalSimulation : INumberAfterDoubleReversal
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(d), where d is the number of digits in num
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsSameAfterReversals(int num)
    {
        var reversed = ReverseNumber(num);
        var reversedAgain = ReverseNumber(reversed);

        return num == reversedAgain;
    }

    private static int ReverseNumber(int number)
    {
        var reversed = 0;

        while (number > 0)
        {
            reversed = (reversed * 10) + (number % 10);

            number /= 10;
        }

        return reversed;
    }
}