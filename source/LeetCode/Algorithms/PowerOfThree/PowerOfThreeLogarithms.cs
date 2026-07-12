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

namespace LeetCode.Algorithms.PowerOfThree;

/// <inheritdoc />
public sealed class PowerOfThreeLogarithms : IPowerOfThree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0)
        {
            return false;
        }

        var logResult = Math.Log10(n) / Math.Log10(3);

        return Math.Abs(logResult - Math.Round(logResult)) < double.Epsilon;
    }
}