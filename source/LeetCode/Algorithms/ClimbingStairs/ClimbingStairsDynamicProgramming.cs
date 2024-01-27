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

namespace LeetCode.Algorithms.ClimbingStairs;

/// <inheritdoc />
public class ClimbingStairsDynamicProgramming : IClimbingStairs
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int ClimbStairs(int n)
    {
        switch (n)
        {
            case 1:
                return 1;
            case 2:
                return 2;
        }

        var values = new int[n + 1];

        values[0] = 1;
        values[1] = 1;

        for (var i = 2; i <= n; i++)
        {
            values[i] = values[i - 1] + values[i - 2];
        }

        return values[n];
    }
}