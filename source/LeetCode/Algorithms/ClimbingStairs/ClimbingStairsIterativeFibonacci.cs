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
public class ClimbingStairsIterativeFibonacci : IClimbingStairs
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
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

        var step1 = 1;
        var step2 = 1;

        for (var i = 2; i < n + 1; i++)
        {
            var step3 = step1 + step2;

            step1 = step2;
            step2 = step3;
        }

        return step2;
    }
}