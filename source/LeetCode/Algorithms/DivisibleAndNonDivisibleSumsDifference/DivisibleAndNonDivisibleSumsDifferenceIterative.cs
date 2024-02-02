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
public class DivisibleAndNonDivisibleSumsDifferenceIterative : IDivisibleAndNonDivisibleSumsDifference
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public int DifferenceOfSums(int n, int m)
    {
        var difference = 0;

        for (var i = 1; i <= n; i++)
        {
            if (i % m == 0)
            {
                difference -= i;
            }
            else
            {
                difference += i;
            }
        }

        return difference;
    }
}