﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.Sqrt;

/// <inheritdoc />
public class SqrtNewtonsMethod : ISqrt
{
    /// <summary>
    ///     Time complexity - O(log x)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public int MySqrt(int x)
    {
        if (x is 0 or 1)
        {
            return x;
        }

        var xOld = x / 2.0;

        while (true)
        {
            var xNew = (xOld + (x / xOld)) / 2;

            if (Math.Abs(xNew - xOld) < 1)
            {
                return (int)xNew;
            }

            xOld = xNew;
        }
    }
}