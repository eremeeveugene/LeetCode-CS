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

namespace LeetCode.Algorithms.CheckGoodInteger;

/// <inheritdoc />
public sealed class CheckGoodIntegerSimulation : ICheckGoodInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsGood(int n)
    {
        var scoreDelta = 0;

        while (n > 0)
        {
            var digit = n % 10;

            scoreDelta += (digit * digit) - digit;

            n /= 10;
        }

        return scoreDelta >= 50;
    }
}