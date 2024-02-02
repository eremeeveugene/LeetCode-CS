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

namespace LeetCode.Algorithms.DivisibleAndNonDivisibleSumsDifference;

/// <inheritdoc />
public class DivisibleAndNonDivisibleSumsDifferenceConstant : IDivisibleAndNonDivisibleSumsDifference
{
    /// <summary>
    ///     Time complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public int DifferenceOfSums(int n, int m)
    {
        return (n * (n + 1) / 2) - (m * ((n / m) + 1) * (n / m));
    }
}