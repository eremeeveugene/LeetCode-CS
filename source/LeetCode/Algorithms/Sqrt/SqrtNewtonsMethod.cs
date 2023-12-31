// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.Sqrt;

/// <summary>
///     https://leetcode.com/problems/sqrtx/description/
/// </summary>
public static class SqrtNewtonsMethod
{
    /// <summary>
    ///     Time complexity - O (1)
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int GetResult(int x)
    {
        if (x is 0 or 1)
        {
            return x;
        }

        double xOld = x / 2.0;

        while (true)
        {
            double xNew = (xOld + (x / xOld)) / 2;

            if (Math.Abs(xNew - xOld) < 1)
            {
                return (int)xNew;
            }

            xOld = xNew;
        }
    }
}